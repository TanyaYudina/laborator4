using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lab4.Models
{
    public class CarsRental
    {
        [Key]
        public int RentId { get; set; }
        public int? CustomerId { get; set; }
        public int? ServiceId { get; set; }
        //public DateTime DateOfIssue { get; set; }
        public int RentalPeriod { get; set; }
        //public DateTime ReturnDate { get; set; }
        public int PriceRental { get; set; }
        public int PaymentNote { get; set; }

        public virtual AdditionalServices AdditionalServices { get; set; }
        public virtual Customers Customers { get; set; }
    }
}
