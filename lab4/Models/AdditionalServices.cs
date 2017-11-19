using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lab4.Models
{
    public class AdditionalServices
    {
        [Key]
        public int ServiceId { get; set; }
        public string AdServName { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        public virtual ICollection<CarsRental> CarsRental { get; set; }

    }
}
