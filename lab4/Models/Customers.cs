using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lab4.Models
{
    public class Customers
    {
        [Key]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }

        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public int PassportData { get; set; }


        public virtual ICollection<CarsRental> CarsRental { get; set; }
    }
}
