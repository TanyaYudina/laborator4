using lab4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab4.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<AdditionalServices> AdditionalServices { get; set; }
        public IEnumerable<CarsRental> CarsRental { get; set; }
        public IEnumerable<Customers> Customers { get; set; }
    }
}
