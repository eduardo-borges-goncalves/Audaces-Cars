using System.Globalization;

namespace ConsoleApp1.Models
{
    public abstract class Vehicle
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
        public Vehicle(
            DateOnly manufacturingDate,
            string name,
            string licensePlate,
            double value,
            string color
            )
        {
            this.Chassis = randNum.Next();
            this.ManufacturingDate = manufacturingDate;
            this.Name = name;
            this.LicensePlate = licensePlate;
            this.Value = value;
            this.Cpf = "0";
            this.Color = color;
            this.Status = "disponivel";
        }

        public virtual void SellVehicle(string cpf)
        {
            this.Cpf = cpf;
            this.Status = "vendido";
        }

        public virtual void ListData()
        {
            Console.WriteLine($"Modelo: {Name}");
            Console.WriteLine($"Cor: {Color}");
            Console.WriteLine($"Valor: {Value.ToString("C", CultureInfo.CurrentCulture)}");
            Console.WriteLine($"Status: {Status}");
            Console.WriteLine($"Placa: {LicensePlate}");
            Console.WriteLine($"Chassi: {Chassis}");
            Console.WriteLine($"Data de Fabricação: {ManufacturingDate}");
        }

        public void UpdateColor(string color)
        {
            this.Color = color;
        }

        public void UpdateValue(int value)
        {
            this.Value = value;
        }
    }
}
