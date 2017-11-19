using lab4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab4.Data
{
    public static class DbInitializer
    {
        public static void Initialize(CarsContext db)
        {
            db.Database.EnsureCreated();

            if (db.CarsRental.Any())
            {
                return;
            }

            //insert data into tables
            Random rnd = new Random();

            for (int i = 1; i < 10; i++)
                db.AdditionalServices.Add(new AdditionalServices { AdServName = "Имя " + rnd.Next(999), Description = "Описание " + rnd.Next(999), Price = rnd.Next(999) });
            db.SaveChanges();

            for (int i = 1; i < 10; i++)
                db.Customers.Add(new Customers { CustomerName = "Имя " + rnd.Next(999), Adress = "Адрес " + rnd.Next(999), PhoneNumber = "Паспорт " + rnd.Next(999), PassportData = rnd.Next(1000000, 9999999) });
            db.SaveChanges();

            for (int i = 1; i < 10; i++)
                db.CarsRental.Add(new CarsRental { CustomerId = i, ServiceId = i, RentalPeriod = rnd.Next(99), PriceRental = rnd.Next(999), PaymentNote = rnd.Next(999999) });
            db.SaveChanges();
        }
    }
}
