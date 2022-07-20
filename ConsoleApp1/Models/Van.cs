using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Van : Vehicle
    {
        public int Doors { get; set; }
        public int BucketCapacity { get; set; }
        public string Power { get; set; }
        public string Fuel { get; set; }

        static string colorVan = "roxo";

        public Van (
            DateOnly manufacturingDate,
            string name,
            string licensePlate,
            double value,
            int doors,
            int bucketCapacity, 
            string fuel,
            string power
            ) : base(manufacturingDate, name, licensePlate, value, colorVan)
        {
            Doors = doors;
            BucketCapacity = bucketCapacity;
            Power = power;
            Fuel = fuel;
        }

        public void showInformation ()
        {
            base.ListData();
            Console.WriteLine($"Portas: {Doors}");
            Console.WriteLine($"Capacidade da Caçamba: {BucketCapacity} litros");
            Console.WriteLine($"Potência: {Power} cavalos");
            Console.WriteLine($"Combustível: {Fuel}");
        }
    }
}
