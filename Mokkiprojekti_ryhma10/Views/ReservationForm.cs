using Microsoft.EntityFrameworkCore;
using Mokkiprojekti_ryhma10.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mokkiprojekti_ryhma10.Views
{
    public partial class ReservationForm : Form
    {
        CottageContext _db = new CottageContext();
        public ReservationForm()
        {
            InitializeComponent();
            cbCottages.ValueMember = "CottageId";
            cbCottages.DisplayMember = "CottageName";
            cbCottages.DataSource = _db.Cottages.ToList();

            cbCustomers.ValueMember = "CustomerId";
            cbCustomers.DisplayMember = "Display";
            cbCustomers.DataSource = _db.Customers.ToList();

            cbServices.ValueMember = "ServiceId";
            cbServices.DisplayMember = "Name";
            cbServices.DataSource = _db.Services.ToList();

            lbReservationServices.ValueMember = "ServiceId";
            lbReservationServices.DisplayMember = "Service.Name";
            dgvReservations.DataSource = _db.Reservations.ToList();
        }
        private void RefreshReservations()
        {
            _db.Reservations.Load();
            dgvReservations.DataSource = _db.Reservations.ToList();
            dgvReservations.Refresh();
        }
        private void RefreshView()
        {
            dgvReservations.DataSource = _db.Reservations.ToList();
            ClearForm();
        }
        private void ClearForm()
        {
            dgvReservations.ClearSelection();
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            dtpReservedDate.Value = DateTime.Now;
            tbID.Text = "";
            cbCottages.SelectedIndex = 0;
            cbCustomers.SelectedIndex = 0;
            tbReservations_Search.Text = "";
            lbReservationServices.Items.Clear();
            tbSum.Text = "";
            nudServices.Value = 1;
        }
        private void btnCreateReservation_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAddService_Click(object sender, EventArgs e)
        {
            if (cbServices.SelectedItem == null)
            {
                return;
            }
            Reservation? selectedReservation = dgvReservations.SelectedOrNull<Reservation>();

            if (selectedReservation != null)
            {

                ReservationService reservationService = new ReservationService
                {
                    Amount = (long)nudServices.Value,
                    Service = cbServices.SelectedItem as Service,
                    ReservationId = selectedReservation.ReservationId
                };
                lbReservationServices.Items.Add(reservationService);
            }
            else
            {
                ReservationService reservationService = new ReservationService
                {
                    Amount = (long)nudServices.Value,
                    Service = cbServices.SelectedItem as Service,
                    ReservationId = getLastId()
                };
                lbReservationServices.Items.Add(reservationService);
            }
        }
        long getLastId()
        {
            long id = (from n in _db.Reservations
                       orderby n.ReservationId descending
                       select n.ReservationId).FirstOrDefault();
            return id + 1;
        }
        private void dgvReservations_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                lbReservationServices.Items.Clear();
                Reservation? selectedReservation = dgvReservations.SelectedOrNull<Reservation>();
                
                if (selectedReservation != null)
                {
                    Invoice? invoice = _db.Invoices
                        .Where(i => i.ReservationId == selectedReservation.ReservationId)
                        .FirstOrDefault();

                    tbID.Text = selectedReservation.ReservationId.ToString();
                    dtpStartDate.Value = selectedReservation.ReservedStartDate;
                    dtpEndDate.Value = selectedReservation.ReservedEndDate;
                    cbCottages.SelectedItem = selectedReservation.Cottage;
                    cbCustomers.SelectedItem = selectedReservation.Customer;
                    dtpReservedDate.Value = selectedReservation.ReservedDate;
                    if (invoice != null)                                        
                    {
                        invoice.Reservation = selectedReservation;
                        tbSum.Text = invoice.Sum.ToString();
                    }
                    long id = selectedReservation.ReservationId;
                    foreach (ReservationService reservationService in _db.ReservationServices)
                    {
                        if (reservationService.ReservationId == id)
                            lbReservationServices.Items.Add(reservationService);
                    }
                    if (selectedReservation.ConfirmationDate.Year == 1)
                    {
                        cbConfirmation.Checked = false;
                    }
                    else
                    {
                        cbConfirmation.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnDeleteSelectedService_Click(object sender, EventArgs e)
        {

            bool IDFilled = long.TryParse(tbID.Text, out long _);
            if (IDFilled)
            {
                Reservation reservationToModify = dgvReservations.SelectedOrNull<Reservation>();
                Invoice? invoice = _db.Invoices
                .Where(i => i.ReservationId == reservationToModify.ReservationId)
                .FirstOrDefault();
                lbReservationServices.BeginUpdate();
                foreach (ReservationService reservationService1 in lbReservationServices.SelectedItems)
                {
                    reservationService1.Reservation = reservationToModify;
                    reservationToModify.ReservationServices.Remove(reservationService1);
                    if (cbVAT.Checked)
                        invoice.Sum -= reservationService1.Amount * reservationService1.Service.Price * 1.1;
                    else 
                        invoice.Sum -= reservationService1.Amount * reservationService1.Service.Price;


                }
                if (lbReservationServices.SelectedIndex == -1)
                {
                    return;
                }
                var selectedIndices = new List<int>(lbReservationServices.SelectedIndices.Cast<int>());
                selectedIndices.Reverse();
                selectedIndices.ForEach(index => lbReservationServices.Items.RemoveAt(index));
                lbReservationServices.EndUpdate();
            }
            else
            {
                lbReservationServices.BeginUpdate();
                var selectedIndices = new List<int>(lbReservationServices.SelectedIndices.Cast<int>());
                selectedIndices.Reverse();
                selectedIndices.ForEach(index => lbReservationServices.Items.RemoveAt(index));
                lbReservationServices.EndUpdate();
            }
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            double servicesum = 0;
            double totalservicesum = 0;
            try
            {
                bool IDFilled = long.TryParse(tbID.Text, out long _);
                if (IDFilled)
                {
                    Reservation reservationToModify = dgvReservations.SelectedOrNull<Reservation>();
                    reservationToModify.ReservedStartDate = dtpStartDate.Value;
                    reservationToModify.ReservedEndDate = dtpEndDate.Value;
                    reservationToModify.Cottage = (Cottage)cbCottages.SelectedItem;
                    reservationToModify.Customer = (Customer)cbCustomers.SelectedItem;
                    reservationToModify.ReservedDate = dtpReservedDate.Value;
                    reservationToModify.ReservationId = long.Parse(tbID.Text);
                    Invoice? invoice = _db.Invoices
                        .Where(i => i.ReservationId == reservationToModify.ReservationId)
                        .FirstOrDefault();

                    if (cbConfirmation.Checked)
                    {
                        reservationToModify.ConfirmationDate = DateTime.Now;
                    }
                    foreach (ReservationService reservationService1 in lbReservationServices.Items)
                    {
                        reservationService1.Reservation = reservationToModify;
                        if (cbVAT.Checked)
                            totalservicesum += reservationService1.Amount * reservationService1.Service.Price * 1.1;
                        else
                            totalservicesum += reservationService1.Amount * reservationService1.Service.Price;
                        if (!_db.ReservationServices.Contains(reservationService1))
                        {
                            if (cbVAT.Checked)
                            {
                                
                                servicesum += reservationService1.Amount * reservationService1.Service.Price * 1.1;
                            }
                            else
                            {
                                
                                servicesum += reservationService1.Amount * reservationService1.Service.Price;
                            }
                        }
                        invoice.Vat = reservationService1.Service.Vat;
                        reservationToModify.ReservationServices.Add(reservationService1);
                    }
                    if (cbVAT.Checked)
                        totalservicesum += reservationToModify.Cottage.Price * 1.1;
                    else
                        totalservicesum += reservationToModify.Cottage.Price;
                    if (cbConfirmation.Checked)
                    {
                        MessageBox.Show("Reservation payment confirmed");
                    }
                    else if ((MessageBox.Show("Confirm reservation?\n" + "\nCottage: " + cbCottages.SelectedItem.ToString() + "\nCustomer: " + cbCustomers.SelectedItem.ToString() + "\nStart date: " +
                        dtpStartDate.Text + "\nEnd date: " + dtpEndDate.Text + "\nTotal price: " + totalservicesum, "", MessageBoxButtons.YesNo) == DialogResult.Yes))
                    {
                        invoice.Sum += servicesum;
                        tbSum.Text = invoice.Sum.ToString();
                        _db.SaveChanges();
                        //InvoicePDFCreator.CreatePDF(reservationToModify); // Jätän vielä hetkeksi kommentin taakse
                        RefreshReservations();
                        ClearForm();
                        lbReservationServices.Items.Clear();
                    }
                }
                else if (dgvReservations.SelectedRows.Count == 0)
                {

                    Reservation reservation = new Reservation();
                    Customer customer = cbCustomers.SelectedItem as Customer;
                    Cottage cottage = cbCottages.SelectedItem as Cottage;
                    Invoice invoice = new Invoice();
                    invoice.ReservationId = getLastId();

                    reservation.Customer = customer;
                    reservation.Cottage = cottage;
                    reservation.ReservedDate = DateTime.Now;
                    reservation.ReservedStartDate = dtpStartDate.Value;
                    reservation.ReservedEndDate = dtpEndDate.Value;
                    Service service = cbServices.SelectedItem as Service;
                    foreach (ReservationService reservationService1 in lbReservationServices.Items)
                    {
                        ReservationService reservationService = new ReservationService();
                        reservationService.Reservation = reservation;
                        reservationService = reservationService1;
                        if (cbVAT.Checked)
                        {
                            servicesum += reservationService1.Amount * reservationService1.Service.Price * 1.1;
                        }
                        else
                        {
                            servicesum += reservationService1.Amount * reservationService1.Service.Price;
                        }
                        invoice.Vat = reservationService1.Service.Vat;
                        reservation.ReservationServices.Add(reservationService);
                    }
                    if (cbVAT.Checked)
                        servicesum += cottage.Price * 1.1;
                    else
                        servicesum += cottage.Price;
                    if (MessageBox.Show("Confirm reservation?\n" + "\nCottage: " + cbCottages.SelectedItem.ToString() + "\nCustomer: " + cbCustomers.SelectedItem.ToString() + "\nStart date: " +
                        dtpStartDate.Text + "\nEnd date: " + dtpEndDate.Text + "\nTotal price: " + servicesum, "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        invoice.Sum += servicesum;
                        reservation.Invoices.Add(invoice);
                        tbSum.Text = invoice.Sum.ToString();
                        _db.Add(reservation);
                        RefreshReservations();
                        ClearForm();
                        lbReservationServices.Items.Clear();
                        _db.SaveChanges();
                        //InvoicePDFCreator.CreatePDF(reservation); Jätän vielä varalta hetkeksi kommentin taakse
                    }
                }
                else
                {
                    MessageBox.Show("Clear selection before making a new reservation");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            RefreshView();
            ClearForm();
        }
        private void btnDiscard_Click(object sender, EventArgs e)
        {
            Reservation? selectedReservation = dgvReservations.SelectedOrNull<Reservation>();
            if (selectedReservation != null)
            {
                try
                {
                    if  (MessageBox.Show("Are you sure you want to discard changes for reservation " + selectedReservation.ReservationId, "Discard changes?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        tbID.Text = selectedReservation.ReservationId.ToString();
                        dtpStartDate.Value = selectedReservation.ReservedStartDate;
                        dtpEndDate.Value = selectedReservation.ReservedEndDate;
                        dtpReservedDate.Value = selectedReservation.ReservedDate;
                        cbCottages.SelectedItem = selectedReservation.Cottage;
                        cbCustomers.SelectedItem = selectedReservation.Customer;
                        lbReservationServices.Items.Clear();
                        foreach (ReservationService reservationService in _db.ReservationServices)
                        {
                            if (reservationService.ReservationId == selectedReservation.ReservationId)
                                lbReservationServices.Items.Add(reservationService);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Reservation? selectedReservation = dgvReservations.SelectedOrNull<Reservation>();
            if (selectedReservation != null)
            {
                if (MessageBox.Show("Are you sure you want to delete reservation " + selectedReservation.ReservationId, "Delete reservation?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _db.Reservations.Remove(selectedReservation);
                    _db.SaveChanges();
                    RefreshView();
                }
            }
        }
        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            Form customersForm = new CustomersForm();
            FormViewerUtil.SwitchForm(this, customersForm);
        }
        private void ReservationForm_VisibleChanged(object sender, EventArgs e)
        {
            _db.Cottages.Load();
            _db.Customers.Load();
            _db.Reservations.Load();
            dgvReservations.DataSource = _db.Reservations.ToList();
            cbCustomers.DataSource = _db.Customers.ToList();
            cbCottages.DataSource = _db.Cottages.ToList();
            cbCustomers.ValueMember = "CustomerId";
            cbCustomers.DisplayMember = "Display";
        }
        private void tbReservations_Search_TextChanged(object sender, EventArgs e)
        {
            string searchValue = tbReservations_Search.Text;
            try
            {
                StringComparison comparison = StringComparison.OrdinalIgnoreCase;
                dgvReservations.DataSource = _db.Reservations.AsEnumerable()
                    .Where(reservation =>
                reservation.Customer.Display.Contains(searchValue, comparison) || reservation.ReservationId.ToString().Contains(searchValue, comparison) ||
                reservation.ReservationId.ToString().Contains(searchValue, comparison) || reservation.Cottage.CottageName.Contains(searchValue, comparison)).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbCottages_SelectedValueChanged(object sender, EventArgs e)
        {
            List<DateTime> bold = new List<DateTime>();
            Cottage? selectedCottage = cbCottages.SelectedItem as Cottage;
            foreach (Reservation reservation in _db.Reservations)
            {
                if (reservation.Cottage == selectedCottage)
                {
                    bold.Add(reservation.ReservedStartDate.Date);
                    bold.Add(reservation.ReservedEndDate.Date);
                    TimeSpan length = reservation.ReservedEndDate.Date - reservation.ReservedStartDate.Date;
                    int days = (int)length.TotalDays;
                    for (int i = 0; i < days; i++)
                    {
                        bold.Add(reservation.ReservedStartDate.Date.AddDays(i));
                    }
                }
            }
            mcStartDate.BoldedDates = bold.ToArray();

            // Jos tämä rikkoo kaiken, niin ottaa pois.
            if (selectedCottage is not null)
            {
                cbServices.ResetText();
                cbServices.DataSource = _db.Services.Where(s => s.AreaId == selectedCottage.AreaId).ToList();
            }
        }
    }
}
