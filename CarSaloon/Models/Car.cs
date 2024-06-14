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
        public string Model { get; set; }
        public bool Available { get; set; }
        public int Price { get; set; }
        public  Country? Country { get; set; }
        public Brand? Brand { get; set; }
        public  TechData? TechData { get; set; }

        public override string ToString()
        {
            return Brand.Title +" "+Model;
        }
    }
}


//Image img = Image.FromFile("путь фото");
//ImageConverter convertObj = new ImageConverter();
//byte[] imgByte = (byte[])convertObj.ConvertTo(img, typeof(byte[]));

//Product pr = new Product();
//pr.Name = //......
//pr.Cost = //.....
//pr.image = imgByte;