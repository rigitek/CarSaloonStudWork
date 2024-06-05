using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSaloon.Models
{
    public class Car
    {
        public int Id { get; set; }
        public virtual Country Country { get; set; }
        public virtual Brand Brand { get; set; }
        public string Model { get; set; }
        public bool Available { get; set; }
        public int Price { get; set; }
    }
}
