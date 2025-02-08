using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSaloon.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public DateTime Date { get; set; }
        public string Payment { get; set; }
        public Client Client { get; set; }
        public Car Car { get; set; }
        public Employee Employee { get; set; }
    }
}
