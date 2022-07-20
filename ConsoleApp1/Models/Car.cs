using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models{
    public class Car : Vehicle
    {

        public int Doors { get; set; }
        public string Fuel { get; set; }
        public string Power { get; set; }

        public Car (
            DateOnly manufacturingDate,
            string name,
            string licensePlate,
            double value,
            string color,
            int doors, 
            string fuel,
            string power
            ) : base(manufacturingDate, name, licensePlate, value, color)
        {
            Doors = doors; 
            Fuel = fuel; 
            Power = power; 
        }

        public void showInformation () {
            base.ListData();
            Console.WriteLine($"Portas: {Doors}");
            Console.WriteLine($"Combustível: {Fuel}");
            Console.WriteLine($"Potência: {Power} cavalos");
        }
    }
}