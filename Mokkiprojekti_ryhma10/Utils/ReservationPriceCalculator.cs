using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Mokkiprojekti_ryhma10.Utils
{
    public static class ReservationPriceCalculator
    {

        // Laskee parametrina saadun varauksen koko hinnan (mökki + palvelut)
        public static double CalculateReservationPrice(Reservation reservationToCalculate)
        {
            using var _context = new CottageContext();
            var prices = _context.Reservations
                .Where(r => r.ReservationId == reservationToCalculate.ReservationId)
                .Include(r => r.Cottage)
                .Include(r => r.ReservationServices)
                .ThenInclude(rs => rs.Service)
                .Select(r => new
                {
                    CottagePrice = r.Cottage.Price,
                    ServicesPrice = r.ReservationServices.Select(rs => rs.Amount * rs.Service.Price).Sum()
                }).FirstOrDefault();

            return prices.CottagePrice + prices.ServicesPrice;
        }

        public static double CottagePriceFromReservation(Reservation reservationToCalculate)
        {
            using var _context = new CottageContext();
            var prices = _context.Reservations
                .Where(r => r.ReservationId == reservationToCalculate.ReservationId)
                .Include(r => r.Cottage)
                .Select(r => new
                {
                    CottagePrice = r.Cottage.Price,
                }).FirstOrDefault();

            return prices.CottagePrice;
        }
    }


}
