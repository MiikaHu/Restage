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
    public partial class MenuForm : Form
    {
        public bool ClosedByXButtonOrAltF4 { get; private set; }
        private const int SC_CLOSE = 0xF060;
        private const int WM_SYSCOMMAND = 0x0112;
        public MenuForm()
        {
            InitializeComponent();
            this.FormClosing += MenuForm_FormClosing;
            // Todo - siirrä lisäys muualle?
            //using (var _db = new CottageContext())
            //{
            // DBSeedUtil.Seed(_db);
            //}
            using (var _db = new CottageContext())
            {
                _db.Database.EnsureCreated();
                //DBSeedUtil.Seed(_db);
            }
        }

        private void btnMngActivities_Click(object sender, EventArgs e)
        {
            Form servicesForm = new ServicesForm();
            FormViewerUtil.SwitchForm(this, servicesForm);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Form customersForm = new CustomersForm();
            FormViewerUtil.SwitchForm(this, customersForm);
        }

        private void btnMngCottages_Click(object sender, EventArgs e)
        {
            Form cottagesForm = new CottagesForm();
            FormViewerUtil.SwitchForm(this, cottagesForm);
        }

        private void btnInvoicing_Click(object sender, EventArgs e)
        {
            Form invoicingForm = new InvoicingForm();
            FormViewerUtil.SwitchForm(this, invoicingForm);
        }

        private void btnMngAreas_Click(object sender, EventArgs e)
        {
            Form areasForm = new AreasForm();
            FormViewerUtil.SwitchForm(this, areasForm);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            Form reservationsForm = new ReservationForm();
            FormViewerUtil.SwitchForm(this, reservationsForm);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Form reportsForm = new ReportsForm();
            FormViewerUtil.SwitchForm(this, reportsForm);
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        protected override void WndProc(ref Message msg)
        {
            if (msg.Msg == WM_SYSCOMMAND && msg.WParam.ToInt32() == SC_CLOSE)
                ClosedByXButtonOrAltF4 = true;
            base.WndProc(ref msg);
        }
        protected override void OnShown(EventArgs e)
        {
            ClosedByXButtonOrAltF4 = false;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (ClosedByXButtonOrAltF4)
            {
                Form loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
