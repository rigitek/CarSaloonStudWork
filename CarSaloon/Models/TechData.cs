using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSaloon.Models
{
    public class TechData
    {
        public int Id { get; set; }
        public int Doors { get; set; }
        public int Seats { get; set; }
        public float EngineCapacity { get; set; }
        public int HorsePower { get; set; }
        public bool ABS { get; set; }
        public bool AC { get; set; }
        public bool Multimedia { get; set; }
        public  Body? Body { get; set; }
        public  EngineType? EngineType { get; set; }
        public  Drive? Drive { get; set; }
        public Steering? Steering { get; set; }
        public Transmission? Transmission { get; set; }
    }
}
