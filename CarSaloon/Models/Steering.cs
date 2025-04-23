using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSaloon.Models
{
    public class Steering
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public override string ToString()
        {
            return Title;
        }
    }
}
