using ConsoleApp1.Data;

namespace ConsoleApp1.Models
{
    public class Moto : Vehicle
    {
        public int Wheels { get; set; }
        public string Power { get; set; }

        public Moto(
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

        public void ShowInformation()
        {
            base.ListData();
            Console.WriteLine($"Rodas: {Wheels}");
            Console.WriteLine($"Potência: {Power} cavalos");
        }

        public override void SellVehicle(string cpf)
        {
            base.SellVehicle(cpf);
            Motos.SellMoto(this);
        }
    }
}