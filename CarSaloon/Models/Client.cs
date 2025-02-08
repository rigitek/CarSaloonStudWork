﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSaloon.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Passport { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }


        public override string ToString()
        {
            return Name;
        }
    }

   
}
