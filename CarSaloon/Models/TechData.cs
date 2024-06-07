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
        public int EngineCapacity { get; set; }
        public int HorsePower { get; set; }
        public  Body? Body { get; set; }
        public  EngineType? EngineType { get; set; }
        public  Drive? Drive { get; set; }
        public Transmission? Transmission { get; set; }
        public int CarId {  get; set; }
        public Car? Car { get; set; }
    }
}
