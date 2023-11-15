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
    public partial class ServicesForm : Form
    {
        private readonly CottageContext _db = new CottageContext();
        public ServicesForm()
        {
            InitializeComponent();
            _db.Services.Load();
            _db.Areas.Load();
            dgvServices.DataSource = _db.Services.ToList();
            cbAreas.DataSource = _db.Areas.ToList();
            cbAreas.DisplayMember = "Name";
            cbAreas.ValueMember = "AreaId";
        }
        private void RefreshServices()
        {
            _db.Services.Load();
            dgvServices.DataSource = _db.Services.ToList();
            dgvServices.Refresh();
        }
        private void RefreshView()
        {
            dgvServices.DataSource = _db.Services.ToList();
            ClearForm();
        }
        private void ClearForm()
        {
            dgvServices.ClearSelection();
            tbID_Activities.Text = "";
            tbName_Activities.Text = "";
            tbType_Activities.Text = "";
            tbPrice_Activities.Text = "";
            tbALV_Activities.Text = "";
            tbDescription_Activities.Text = "";
            cbAreas.Text = "";
            cbAreas.SelectedIndex = 0;
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Hide();
        }

        private void btnCreateNew_Activities_Click(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void btnSave_Activities_Click(object sender, EventArgs e)
        {
            try
            {
                bool IDFilled = long.TryParse(tbID_Activities.Text, out long _);
                if (IDFilled)
                {
                    Service serviceToModify = dgvServices.SelectedOrNull<Service>();
                    serviceToModify.Name = tbName_Activities.Text.NullIfWhiteSpace();
                    serviceToModify.Type = long.Parse(tbType_Activities.Text.NullIfWhiteSpace());
                    serviceToModify.AreaId = (long)cbAreas.SelectedValue;
                    serviceToModify.Price = double.Parse(tbPrice_Activities.Text.NullIfWhiteSpace());
                    serviceToModify.Description = tbDescription_Activities.Text.NullIfWhiteSpace();
                    serviceToModify.ServiceId = long.Parse(tbID_Activities.Text);
                    serviceToModify.Vat = double.Parse(tbALV_Activities.Text.NullIfWhiteSpace());
                }
                else if (dgvServices.SelectedRows.Count == 0) //TODO - TÄMÄ JOKA FORMILLE JA CREATE NEW NAPPI CLEARIKS
                {
                    Service newservice = new Service()
                    {
                        Name = tbName_Activities.Text.NullIfWhiteSpace(),
                        Type = long.Parse(tbType_Activities.Text.NullIfWhiteSpace()),
                        Price = double.Parse(tbPrice_Activities.Text.NullIfWhiteSpace()),
                        Description = tbDescription_Activities.Text.NullIfWhiteSpace(),
                        Vat = double.Parse(tbALV_Activities.Text.NullIfWhiteSpace()),
                        AreaId = (long)cbAreas.SelectedValue,
                    }; _db.Services.Add(newservice);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            _db.SaveChanges();
            RefreshView();
        }

        private void dgvServices_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Service? selectedService = dgvServices.SelectedOrNull<Service>();
                if (selectedService != null)
                {
                    tbID_Activities.Text = selectedService.ServiceId.ToString();
                    tbName_Activities.Text = selectedService.Name;
                    tbType_Activities.Text = selectedService.Type.ToString();
                    tbPrice_Activities.Text = selectedService.Price.ToString();
                    tbDescription_Activities.Text = selectedService.Description;
                    tbALV_Activities.Text = selectedService.Vat.ToString();
                    cbAreas.SelectedItem = selectedService.Area;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ServicesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _db.Dispose();
        }

        private void ServicesForm_VisibleChanged(object sender, EventArgs e)
        {
            _db.Services.Load();
            _db.Areas.Load();
            dgvServices.DataSource = _db.Services.ToList();
            cbAreas.DataSource = _db.Areas.ToList();
            cbAreas.DisplayMember = "Name";
            cbAreas.ValueMember = "AreaId";
        }

        private void btnNewArea_Click(object sender, EventArgs e)
        {
            Form areasForm = new AreasForm();
            FormViewerUtil.SwitchForm(this, areasForm);
        }

        private void tbNameSearch_Activities_TextChanged(object sender, EventArgs e)
        {
            string searchValue = tbNameSearch_Activities.Text;
            try
            {
                StringComparison comparison = StringComparison.OrdinalIgnoreCase;
                dgvServices.DataSource = _db.Services.AsEnumerable()
                    .Where(service =>
                service.Name.Contains(searchValue, comparison) || service.ServiceId.ToString().Contains(searchValue, comparison) ||
                service.Type.ToString().Contains(searchValue, comparison) || service.Price.ToString().Contains(searchValue, comparison) || 
                service.AreaId.ToString().Contains(searchValue, comparison) || service.Vat.ToString().Contains(searchValue, comparison) || 
                service.Description.Contains(searchValue, comparison)).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbPrice_Activities_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbALV_Activities_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbALV_Activities.MaxLength = 2;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Service? selectedService = dgvServices.SelectedOrNull<Service>();
            try
            {
                if (MessageBox.Show("Are you sure you want to delete service " + selectedService.Name, "Delete service?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (selectedService != null)
                    {
                        // TODO - Tarvitseeko välttämättä db:stä etsiä asiakas ID:n avulla, kun sen kerran sai noudettua DGV:stä
                        _db.Services.Remove(selectedService);
                        _db.SaveChanges();
                        RefreshView();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
           

        private void btnDiscard_Activities_Click(object sender, EventArgs e)
        {
            Service? selectedService = dgvServices.SelectedOrNull<Service>();
            if (MessageBox.Show("Are you sure you want to discard changes for service " + selectedService.Name, "Discard changes?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (selectedService != null)
                    {
                        tbID_Activities.Text = selectedService.ServiceId.ToString();
                        tbName_Activities.Text = selectedService.Name;
                        tbPrice_Activities.Text = selectedService.Price.ToString();
                        tbDescription_Activities.Text = selectedService.Description;
                        tbALV_Activities.Text = selectedService.Vat.ToString();
                        tbType_Activities.Text = selectedService.Type.ToString();
                        cbAreas.SelectedItem = selectedService.Area;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
