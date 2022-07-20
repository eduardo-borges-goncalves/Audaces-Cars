using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Vehicle
    {
        public int Chassis { get; set; }
        public DateOnly ManufacturingDate { get; set; }
        public string Name { get; set; }
        public string LicensePlate { get; set; }
        public double Value { get; set; }
        public string Cpf { get; set; }
        public string Color { get; set; }
        public string Status { get; set; }

        Random randNum = new Random();
        public Vehicle (
            DateOnly manufacturingDate,
            string name, 
            string licensePlate, 
            double value, 
            string cpf, 
            string color
            )
        {
            this.Chassis = randNum.Next();
            this.ManufacturingDate = manufacturingDate;
            this.Name = name;
            this.LicensePlate = licensePlate;
            this.Value = value;
            this.Cpf = cpf;
            this.Color = color;
            this.Store = 0;
            this.Status = "disponível"
        }

        public void SellVehicle (int value)
        {
            this.Status = "vendido"
        }

        public void ListData ()
        {
            Console.WriteLine($"Modelo: {Name}");
            Console.WriteLine($"Chassi: {Chassis}");
            Console.WriteLine($"Placa: {LicensePlate}");
            Console.WriteLine($"Valor: R$ {Value:F2}");
            Console.WriteLine($"Estoque: {Store}");
        }

        public void SetColor (string color)
        {
            this.Color = color;
        }

        public void SetValue (int value)
        {
            this.Value = value;
        }
    }
}
