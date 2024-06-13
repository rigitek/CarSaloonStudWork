using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSaloon.Models
{
    public class Sales
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public DateOnly Date { get; set; }
        public Client Client { get; set; }
        public Car Car { get; set; }
    }
}
