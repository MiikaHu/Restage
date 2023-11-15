using Microsoft.EntityFrameworkCore;
using Mokkiprojekti_ryhma10.Utils;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;

namespace Mokkiprojekti_ryhma10.Views
{
    public partial class ReportsForm : Form
    {
        private readonly CottageContext _context = new CottageContext();

        private enum ShowReport { Cottage, Service };
        private ShowReport _showReport = ShowReport.Cottage;

        public ReportsForm()
        {
            InitializeComponent();
            cbArea.DataSource = _context.Areas.ToList();
            //UpdateUI();
        }

        private void UpdateUI()
        {
            switch (_showReport)
            {
                case ShowReport.Cottage:
                    ShowCottageReports();
                    break;
                case ShowReport.Service:
                    ShowServiceReports();
                    break;
            }
        }

        private void ShowCottageReports()
        {
            Area selectedArea = cbArea.SelectedItem as Area;
            if (cbUseDates.Checked)
            {
                DateTime startDate = dtpStartDate.Value;
                DateTime endDate = dtpEndDate.Value;
                dgvReports.DataSource = _context.Reservations
                    .Where(r => r.Cottage.AreaId == selectedArea.AreaId
                                && r.ReservedDate >= startDate && r.ReservedDate <= endDate).ToList();
            }
            else
            {
                dgvReports.DataSource = _context.Reservations.Where(r => r.Cottage.AreaId == selectedArea.AreaId).ToList();
            }
            CalculateCottageTotal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }


        

        // Raportista tulee selvitä halutulle alueelle tehtyjen toteutuneiden(?) varausten määrä ja kokonaishinta 
        private void CalculateCottageTotal()
        {
            double totalSum = 0;

            foreach (DataGridViewRow row in dgvReports.Rows)
            {
                Reservation reservation = row.DataBoundItem as Reservation;
                totalSum += ReservationPriceCalculator.CottagePriceFromReservation(reservation);
            }

            tbSumOfReservations.Text = totalSum.ToString();
            tbReservationsInArea.Text = dgvReports.Rows.Count.ToString();
        }

        

        private void cbUseDates_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            _showReport = ShowReport.Service;
            UpdateUI();
        }

        private void btnCottage_Click(object sender, EventArgs e)
        {
            _showReport = ShowReport.Cottage;
            UpdateUI();
        }

        

        private void ShowServiceReports()
        {
            Area selectedArea = cbArea.SelectedItem as Area;
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            Expression<Func<Reservation, bool>> useDate = r => r.ReservedStartDate >= startDate && r.ReservedEndDate <= endDate;
            Expression<Func<Reservation, bool>> noDate = _ => true;
            Expression<Func<Reservation, bool>> filterToUse = cbUseDates.Checked ? useDate : noDate;

            var allReservations = _context.Reservations.Where(r => r.Cottage.AreaId == selectedArea.AreaId)
                    .Where(filterToUse)
                .Include(res => res.ReservationServices)
                .ThenInclude(rs => rs.Service);

            var services = allReservations.AsEnumerable().SelectMany(r => r.ReservationServices)
                .GroupBy(r => r.Service.Name)
                .Select(r => (r.Key, services: r.ToList()));
            var serviceInfo = services.Select(r => new
            {
                Name = r.Key,
                Amount = r.services.Select(s => s.Amount).Sum(),
                Total = r.services.Select(s => s.Amount * s.Service.Price).Sum()
            }).ToList();

            dgvReports.DataSource = serviceInfo;

            var totalCost = serviceInfo.Select(i => i.Amount * i.Total).Sum();
            var totalServicesBought = serviceInfo.Select(i => i.Amount).Sum();
            tbReservationsInArea.Text = totalServicesBought.ToString();
            tbSumOfReservations.Text = totalCost.ToString();


        }

        
    }
}
