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
    public partial class CustomersForm : Form
    {
        private readonly CottageContext _context = new CottageContext();
        public CustomersForm()
        {
            InitializeComponent();
            cbPostalCode.DataSource = _context.Posts.ToList();
            cbPostalCode.DisplayMember = "Display";
            cbPostalCode.ValueMember = "PostalCode";
            //RefreshView();
        }

        // TODO Joku noheva voisi asetella napit paremmin :D

        private void RefreshView()
        {
            dgvCustomers.DataSource = _context.Customers.ToList();
            ClearForm();
        }


        private void btnSave_Customers_Click(object sender, EventArgs e)
        {
            bool IDFilled = long.TryParse(tbID_Customers.Text, out long _);
            if (IDFilled) // Jos ID-kenttä ei ole tyhjä, muokataan olemassa olevaa asiakasta
            {
                Customer customerToModify = dgvCustomers.SelectedOrNull<Customer>();
                customerToModify.FirstName = tbFirstName_Customers.Text.NullIfWhiteSpace();
                customerToModify.LastName = tbLastName_Customers.Text.NullIfWhiteSpace();
                customerToModify.Address = tbAddress_Customers.Text.NullIfWhiteSpace();
                customerToModify.Email = tbEmail_Customers.Text.NullIfWhiteSpace();
                customerToModify.Phonenumber = tbPhoneNumber_Customers.Text.NullIfWhiteSpace();
                customerToModify.PostId = (string)cbPostalCode.SelectedValue;
                // Muokattavaa oliota ei tarvitse erikseen lisätä minnekään, EF Core osaa hoitaa päivittämisen
            }
            else if (dgvCustomers.SelectedRows.Count == 0) //TODO - TÄMÄ JOKA FORMILLE JA CREATE NEW NAPPI CLEARIKS
            {
                Customer newCustomer = new Customer();
                newCustomer.FirstName = tbFirstName_Customers.Text.NullIfWhiteSpace();
                newCustomer.LastName = tbLastName_Customers.Text.NullIfWhiteSpace();
                newCustomer.Address = tbAddress_Customers.Text.NullIfWhiteSpace();
                newCustomer.Email = tbEmail_Customers.Text.NullIfWhiteSpace();
                newCustomer.Phonenumber = tbPhoneNumber_Customers.Text.NullIfWhiteSpace();
                newCustomer.PostId = (string)cbPostalCode.SelectedValue;
                _context.Customers.Add(newCustomer);
            }

            _context.SaveChanges();
            RefreshView();
        }

        private void CustomersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }

        private void btnDiscard_Customers_Click(object sender, EventArgs e)
        {
            Customer? selectedCustomer = dgvCustomers.SelectedOrNull<Customer>();
            if (selectedCustomer != null)
            {
                if (MessageBox.Show($"Are you sure you want to discard changes for customer {selectedCustomer.FirstName} {selectedCustomer.LastName}", "Discard changes?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    tbID_Customers.Text = selectedCustomer.CustomerId.ToString();
                    tbFirstName_Customers.Text = selectedCustomer.FirstName;
                    tbLastName_Customers.Text = selectedCustomer.LastName;
                    tbAddress_Customers.Text = selectedCustomer.Address;
                    tbEmail_Customers.Text = selectedCustomer.Email;
                    tbPhoneNumber_Customers.Text = selectedCustomer.Phonenumber;
                    cbPostalCode.SelectedItem = selectedCustomer.Post;
                }
            }
        }


        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Customer? selectedCustomer = dgvCustomers.SelectedOrNull<Customer>();
            if (selectedCustomer != null)
            {
                tbID_Customers.Text = selectedCustomer.CustomerId.ToString();
                tbFirstName_Customers.Text = selectedCustomer.FirstName;
                tbLastName_Customers.Text = selectedCustomer.LastName;
                tbAddress_Customers.Text = selectedCustomer.Address;
                tbEmail_Customers.Text = selectedCustomer.Email;
                tbPhoneNumber_Customers.Text = selectedCustomer.Phonenumber;
                cbPostalCode.SelectedItem = selectedCustomer.Post;
            }
        }

  /*      private void cbPostalCode_Leave(object sender, EventArgs e)
        {
            if (cbPostalCode.SelectedItem == null)
            {
                tssLabel.Text = "Invalid postal code!";
                cbPostalCode.Focus();
            }
            else
            {
                tssLabel.Text = "";
            }
        }*/

        private void btnCreateNew_Customers_Click(object sender, EventArgs e)
        {
            RefreshView();
            ClearForm();
        }

        private void ClearForm()
        {
            dgvCustomers.ClearSelection();
            tbID_Customers.Text = "";
            tbFirstName_Customers.Text = "";
            tbLastName_Customers.Text = "";
            tbAddress_Customers.Text = "";
            tbEmail_Customers.Text = "";
            tbPhoneNumber_Customers.Text = "";
            cbPostalCode.SelectedIndex = 0;
        }

        private void tbNameSearch_Customers_TextChanged(object sender, EventArgs e)
        {
            // TODO
            // Ei välttämättä hyvä idea, jos rivejä on paljon, jumittaako pahasti?
            // Pitää miettiä jos keksisi paremman tavan, esim. ComboBox
            // josta valittaisiin minkä kentän perusteella haluaa etsiä?
            // En muista oliko jossain maininta, että haettaisiin vain nimen perusteella 
            string searchValue = tbNameSearch_Customers.Text;
            StringComparison comparison = StringComparison.OrdinalIgnoreCase;
            dgvCustomers.DataSource = _context.Customers.AsEnumerable()
                .Where(customer =>
            customer.FirstName.Contains(searchValue, comparison) || customer.LastName.Contains(searchValue, comparison) ||
            customer.Address.Contains(searchValue, comparison) || customer.Post.Display.Contains(searchValue, comparison) ||
            customer.Phonenumber.Contains(searchValue, comparison) || customer.Email.Contains(searchValue, comparison))
                .ToList();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbPostalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Customer? selectedCustomer = dgvCustomers.SelectedOrNull<Customer>();
            if (selectedCustomer != null)
            {
                if (MessageBox.Show($"Are you sure you want to delete all information for customer {tbFirstName_Customers.Text} {tbLastName_Customers.Text}?", "Delete customer?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _context.Customers.Remove(selectedCustomer);
                    _context.SaveChanges();
                    RefreshView();
                }
            }
        }


    }
}
