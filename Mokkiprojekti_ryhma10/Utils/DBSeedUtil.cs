using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mokkiprojekti_ryhma10.Utils
{
    internal class DBSeedUtil
    {

        internal static void Seed(CottageContext _db)
        {


            //// TODO - Mitä toimipaikka (PostOffice) kenttään laitetaan?
            //var PostData = new Post[] {
            //    new Post { PostalCode = "70000", PostOffice = "Kuopio" },
            //    new Post { PostalCode = "33000", PostOffice = "Tampere" },
            //    new Post { PostalCode = "90000", PostOffice = "Oulu" }
            //};

            //var AreaData = new Area[] {
            //    new Area { AreaId = 1, Name = "Kuopio" },
            //    new Area { AreaId = 2, Name = "Tampere" },
            //    new Area { AreaId = 3, Name = "Oulu" }
            //};

            // Lisää ^^^^ takaisin jos tarve vaatii, tai poistaa vaikka koko luokan, jos tarvetta tälle ei enää ole

            if (!_db.Cottages.Any())
            {
                var CottageData = new Cottage[] {
                new Cottage { CottageId = 1, PostId = "70100", CottageName = "Juhan lomamökki", AreaId = 1, Address = "Mökkikatu 2", Price = 120, Description = "Tilava mökki lähellä Kuopion keskustan palveluita", Amenities = "Sauna, 5mh, 2kph", AmountOfPeople = 10 },
                new Cottage { CottageId = 2, PostId = "33300", CottageName = "Lomakeskus Mökkilä", AreaId = 2, Address = "Lomakuja 78", Price = 200, Description = "Moderni mökki Tampereen kupeessa", Amenities = "Sauna, poreallas, WiFi", AmountOfPeople = 2 }
            };
                _db.AddRange(CottageData);

            }


            if (!_db.Services.Any())
            {
                var ServiceData = new Service[] {
                new Service { ServiceId = 1, AreaId = 1, Name = "Museokierros",  Type = 1, Price = 20, Description = "Tutustu Kuopion museoon oppaan kanssa", Vat = 12 },
                new Service { ServiceId = 2, AreaId = 2, Name = "Särkänniemi",  Type = 2, Price = 50, Description = "Vietä päivä Särkänniemessä", Vat = 12 }
            };
                _db.AddRange(ServiceData);

            }

            if (!_db.Customers.Any())
            {
                var CustomerData = new Customer[]
              {
                new Customer { CustomerId = 1, PostId = "70100", FirstName = "Seppo", LastName = "Niskanen", Address = "Kujakatu 2", Email = "s.niskanen@niskanen.fi", Phonenumber = "0501431238"},
                new Customer { CustomerId = 2, PostId = "33300", FirstName = "Marja", LastName = "Salminen", Address = "Metsätie 21", Email = "marja.salminen@gmail.com", Phonenumber = "0449834455"},
              };
                _db.AddRange(CustomerData);

            }
            _db.SaveChanges();
        }
    }
}
