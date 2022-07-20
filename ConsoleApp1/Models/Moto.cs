using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models{
    public class Moto: Vehicle 
    {
        public int Wheels { get; set; }
        public string Power { get; set;  }

        public Moto (
            DateOnly manufacturingDate,
            string name,
            string licensePlate,
            double value,
            string color,
            int wheels, 
            string power
            ) : base(manufacturingDate, name, licensePlate, value, color)
        {
            Wheels = wheels; 
            Power = power; 
        }
    }
}