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
    public partial class InvoicingForm : Form
    {
        CottageContext _db = new CottageContext();
        public InvoicingForm()
        {
            InitializeComponent();
            _db.Invoices.Load();
            _db.Customers.Load();
            _db.Cottages.Load();
            _db.ReservationServices.Load();
            dgvInvoicing.DataSource = _db.Invoices.ToList();
            lbServices_Invoicing.ValueMember = "ServiceId";
            lbServices_Invoicing.DisplayMember = "Service.Name";
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Hide();
        }
        private void RefreshView()
        {
            dgvInvoicing.DataSource = _db.Invoices.ToList();
            ClearForm();
        }
        private void ClearForm()
        {
            dgvInvoicing.ClearSelection();
            tbALV_Invoicing.Text = "";
            tbCottageName_Invoicing.Text = "";
            tbID_Invoicing.Text = "";
            tbLength_Invoicing.Text = "";
            tbNameSearch_Invoicing.Text = "";
            tbResID_Invoicing.Text = "";
            tbSum_Invoicing.Text = "";
            lbServices_Invoicing.Items.Clear();
            tbName_Invoicing.Text = "";
        }

        private void InvoicingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _db.Dispose();
        }

        private void tbNameSearch_Invoicing_TextChanged(object sender, EventArgs e)
        {
            string searchValue = tbNameSearch_Invoicing.Text;
            try
            {
                StringComparison comparison = StringComparison.OrdinalIgnoreCase;
                dgvInvoicing.DataSource = _db.Invoices.AsEnumerable()
                    .Where(Invoice =>
                Invoice.InvoiceId.ToString().Contains(searchValue, comparison) || Invoice.Sum.ToString().Contains(searchValue, comparison) ||
                Invoice.ReservationId.ToString().Contains(searchValue, comparison) || Invoice.Vat.ToString().Contains(searchValue, comparison)).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvInvoicing_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Invoice? selectedInvoice = dgvInvoicing.SelectedOrNull<Invoice>();
                var reservation = _db.Reservations.Where(r => r.Invoices.Contains(selectedInvoice))
                                   .Include(r => r.Cottage).Include(r => r.Customer).Include(r => r.ReservationServices).ThenInclude(r => r.Service)
                                   .FirstOrDefault();
                if (selectedInvoice != null)
                {
                    lbServices_Invoicing.Items.Clear();
                    tbID_Invoicing.Text = selectedInvoice.InvoiceId.ToString();
                    tbSum_Invoicing.Text = selectedInvoice?.Sum.ToString();
                    tbResID_Invoicing.Text = selectedInvoice.ReservationId.ToString();
                    tbALV_Invoicing.Text = selectedInvoice?.Vat.ToString();
                    tbCottageName_Invoicing.Text = reservation.Cottage.ToString();
                    tbName_Invoicing.Text = reservation.Customer.ToString();
                    TimeSpan length = reservation.ReservedEndDate - reservation.ReservedStartDate;
                    tbLength_Invoicing.Text = (length.Days + 2).ToString();
                    foreach (ReservationService reservationService in reservation.ReservationServices)
                    {
                        if (reservationService.ReservationId == reservation.ReservationId)
                            lbServices_Invoicing.Items.Add(reservationService);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDiscard_Invoicing_Click(object sender, EventArgs e)
        {
            Invoice? selectedInvoice = dgvInvoicing.SelectedOrNull<Invoice>();
            if (MessageBox.Show("Are you sure you want to delete invoice " + selectedInvoice.InvoiceId, "Delete invoice?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (selectedInvoice != null)
                {
                    _db.Invoices.Remove(selectedInvoice);
                    _db.SaveChanges();
                    RefreshView();
                }
            }
        }

        private void cbLateDueDate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLateDueDate.Checked)
            {
                dgvInvoicing.DataSource = _db.Invoices.Include(i => i.Reservation).Where(i => i.Reservation.ReservedDate.AddDays(15) < DateTime.Now && i.Reservation.ConfirmationDate.Year == 1)
                .ToList();
            }
            else dgvInvoicing.DataSource = _db.Invoices.ToList();
        }

        private async void btnPrintPDF_Click(object sender, EventArgs e)
        {
            Invoice? selectedInvoice = dgvInvoicing.SelectedOrNull<Invoice>();
            var reservation = _db.Reservations.Where(r => r.Invoices.Contains(selectedInvoice)).FirstOrDefault();
            btnPrintPDF.Text = "Printing...";
            btnPrintPDF.Enabled = false;
            await InvoicePDFCreator.CreatePDF(reservation);
            btnPrintPDF.Text = "Print to PDF";
            btnPrintPDF.Enabled = true;
        }
    }
}
