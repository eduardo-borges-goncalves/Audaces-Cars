using ConsoleApp1.Data;

namespace ConsoleApp1.Models
{
    public enum FuelVan
    {
        diesel = 1,
        gasolina = 2
    }
    public class Van : Vehicle
    {
        public int Doors { get; set; }
        public int BucketCapacity { get; set; }
        public string Power { get; set; }
        public FuelVan Fuel { get; set; }

        static string ColorVan = "roxo";

        public Van (
            DateOnly manufacturingDate,
            string name,
            string licensePlate,
            double value,
            int doors,
            int bucketCapacity,
            FuelVan fuel,
            string power
            ) : base(manufacturingDate, name, licensePlate, value, ColorVan)
        {
            Doors = doors;
            BucketCapacity = bucketCapacity;
            Power = power;
            Fuel = fuel;
        }

        public void ShowInformation ()
        {
            base.ListData();
            Console.WriteLine($"Portas: {Doors}");
            Console.WriteLine($"Capacidade da Caçamba: {BucketCapacity} litros");
            Console.WriteLine($"Potência: {Power} cavalos");
            Console.WriteLine($"Combustível: {Fuel}");
        }

        public override void SellVehicle(string cpf)
        {
            base.SellVehicle(cpf);
            Vans.SellVan(this);
        }
    }
}
