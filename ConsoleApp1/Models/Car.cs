using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models{
    public class Car : Vehicle
    {
        enum Fuel {
            gasolina, 
            diesel
        };

        public int Doors { get; set; }
        public Fuel Fuel { get; set; }
        public string Power { get; set; }

        public Car (int doors, Fuel fuel, string power) {
            Doors = doors; 
            Fuel = fuel; 
            power = power; 
        }

        public void showInformation () {
            Console.WriteLine($"Portas {Doors}");
            Console.WriteLine($"Combustível {Fuel}");
            Console.WriteLine($"Potência {Power} cavalos");
        }
    }
}