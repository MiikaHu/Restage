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
using System.Collections;

namespace Mokkiprojekti_ryhma10.Views
{
    public partial class CottagesForm : Form
    {
        private readonly CottageContext _context = new CottageContext();

        public CottagesForm()
        {
            InitializeComponent();

            _context.Cottages.Load();
            _context.Posts.Load();
            _context.Areas.Load();
            dgvCottages.DataSource = _context.Cottages.ToList();
            cbPostalCode.DataSource = _context.Posts.ToList();
            cbPostalCode.DisplayMember = "PostalCode";
            cbPostalCode.ValueMember = "PostalCode";
            cbAreas.DataSource = _context.Areas.ToList();
            cbAreas.DisplayMember = "Name";
            cbAreas.ValueMember = "AreaId";
        }
        private void RefreshCottages()
        {
            _context.Cottages.Load();
            dgvCottages.DataSource = _context.Cottages.ToList();
            dgvCottages.Refresh();
        }
        private void RefreshView()
        {
            dgvCottages.DataSource = _context.Cottages.ToList();
            ClearForm();
        }
        private void ClearForm()
        {
            dgvCottages.ClearSelection();
            tbID.Text = "";
            tbName.Text = "";
            tbAddress.Text = "";
            tbAmenities.Text = "";
            tbAmount.Text = "";
            tbDescription.Text = "";
            tbPrice.Text = "";
            cbPostalCode.Text = "";
            cbAreas.SelectedIndex = 0;
        }
        private void btnCreateNew_Click(object sender, EventArgs e) // Tämä tod.näk pois ja hoidetaan vaan Save napilla
        {
            RefreshCottages();
            ClearForm();
        }

        private void btnSave_Click(object sender, EventArgs e)  // olemassa olevan mökin tallentamiseen
        {
            try
            {
                bool IDFilled = long.TryParse(tbID.Text, out long _);
                if (IDFilled)
                {
                    Cottage cottageToModify = dgvCottages.SelectedOrNull<Cottage>();
                    cottageToModify.PostId = (string)cbPostalCode.SelectedValue;
                    cottageToModify.CottageName = tbName.Text;
                    cottageToModify.Address = tbAddress.Text.NullIfWhiteSpace();
                    cottageToModify.AreaId = (long)cbAreas.SelectedValue;
                    cottageToModify.Price = double.Parse(tbPrice.Text);
                    cottageToModify.Description = tbDescription.Text.NullIfWhiteSpace();
                    cottageToModify.AmountOfPeople = int.Parse(tbAmount.Text);
                    cottageToModify.Amenities = tbAmenities.Text.NullIfWhiteSpace();
                    cottageToModify.CottageId = long.Parse(tbID.Text);
                }
                else if (dgvCottages.SelectedRows.Count == 0) //TODO - TÄMÄ JOKA FORMILLE JA CREATE NEW NAPPI CLEARIKS
                {
                    Cottage newCottage = new Cottage()
                    {
                        CottageName = tbName.Text.NullIfWhiteSpace(),
                        Address = tbAddress.Text.NullIfWhiteSpace(),
                        Price = double.Parse(tbPrice.Text),
                        Description = tbDescription.Text.NullIfWhiteSpace(),
                        AmountOfPeople = int.Parse(tbAmount.Text),
                        Amenities = tbAmenities.Text.NullIfWhiteSpace(),
                        PostId = (string)cbPostalCode.SelectedValue,
                        AreaId = (long)cbAreas.SelectedValue,
                    }; _context.Cottages.Add(newCottage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            _context.SaveChanges();
            RefreshView();
            ClearForm();
        }

        private void dgvCottages_SelectionChanged(object sender, EventArgs e)   //tuodaan valitun mökin tiedot syöttökenttiin (ei väliä mistä kohti riviä painaa)
        {
            try
            {
            Cottage? selectedCottage = dgvCottages.SelectedOrNull<Cottage>();
            if (selectedCottage != null)
            {
                tbID.Text = selectedCottage.CottageId.ToString();
                tbName.Text = selectedCottage.CottageName;
                tbAddress.Text = selectedCottage.Address;
                tbPrice.Text = selectedCottage.Price.ToString();
                tbDescription.Text = selectedCottage.Description;
                tbAmount.Text = selectedCottage.AmountOfPeople.ToString();
                tbAmenities.Text = selectedCottage.Amenities;
                cbPostalCode.Text = selectedCottage.PostId;
                cbAreas.SelectedItem = selectedCottage.Area;
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnMenu_Click(object sender, EventArgs e) //palataan menu valikkoon
        {
            this.Close();
        }

        private void Cottages_FormClosing(object sender, FormClosingEventArgs e) //formin sulkeutuessa katkaistaan tietokanta yhteys
        {
            _context.Dispose();
        }

        private void Cottages_VisibleChanged(object sender, EventArgs e) //ladataan dgv ja cb uudestaan, käyttö tarkoitus on
        {                                                                // kun luodaan uusi Area ja palataan CottageFormille.
            _context.Cottages.Load();
            _context.Posts.Load();
            _context.Areas.Load();
            dgvCottages.DataSource = _context.Cottages.ToList();
            cbPostalCode.DataSource = _context.Posts.ToList();
            cbAreas.DataSource = _context.Areas.ToList();
            cbAreas.DisplayMember = "Name";
            cbAreas.ValueMember = "AreaId";
        }

        private void btnDiscard_Click(object sender, EventArgs e) //Poistetaan valittu mökki dgv:stä ja tietokannasta
        {
            Cottage? selectedCottage = dgvCottages.SelectedOrNull<Cottage>();
            if (MessageBox.Show("Are you sure you want to discard changes for cottage " + selectedCottage.CottageName, "Discard changes?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (selectedCottage != null)
                    {
                        tbID.Text = selectedCottage.CottageId.ToString();
                        tbName.Text = selectedCottage.CottageName;
                        tbAddress.Text = selectedCottage.Address;
                        tbPrice.Text = selectedCottage.Price.ToString();
                        tbDescription.Text = selectedCottage.Description;
                        tbAmount.Text = selectedCottage.AmountOfPeople.ToString();
                        tbAmenities.Text = selectedCottage.Amenities;
                        cbPostalCode.Text = selectedCottage.PostId;
                        cbAreas.SelectedItem = selectedCottage.Area;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAddNewArea_Click(object sender, EventArgs e)
        {
            Form areasForm = new AreasForm();
            FormViewerUtil.SwitchForm(this, areasForm);
        }

        private void tbSearchByName_TextChanged(object sender, EventArgs e) //TODO Testata miten toimii kun dataa on paljon
        {
            string searchValue = tbSearchByName.Text;
            try
            {
                StringComparison comparison = StringComparison.OrdinalIgnoreCase;
                dgvCottages.DataSource = _context.Cottages.AsEnumerable()
                    .Where(cottage =>
                cottage.CottageName.Contains(searchValue, comparison) || cottage.CottageId.ToString().Contains(searchValue, comparison) ||
                cottage.Address.Contains(searchValue, comparison) || cottage.Post.Display.Contains(searchValue, comparison) ||
                cottage.Price.ToString().Contains(searchValue, comparison) || cottage.AreaId.ToString().Contains(searchValue, comparison) ||
                cottage.AmountOfPeople.ToString().Contains(searchValue, comparison) || cottage.Description.Contains(searchValue, comparison)).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbPostalCode_Leave(object sender, EventArgs e)
        {
            if (cbPostalCode.Text == "" || cbPostalCode.Text.Length < 5)
            {
                cbPostalCode.Focus();
            }
        }

        private void cbAreas_Leave(object sender, EventArgs e)
        {
            if (cbAreas.Text == "")
            {
                Application.DoEvents();
                cbAreas.Focus();
            }
        }

        private void cbPostalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            cbPostalCode.MaxLength = 5;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Cottage? selectedCottage = dgvCottages.SelectedOrNull<Cottage>();
            if (MessageBox.Show("Are you sure you want to delete cottage " + selectedCottage.CottageName, "Delete cottage?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (selectedCottage != null)
                {
                    _context.Cottages.Remove(selectedCottage);
                    _context.SaveChanges();
                    RefreshView();
                }
            }
        }
    }
}
