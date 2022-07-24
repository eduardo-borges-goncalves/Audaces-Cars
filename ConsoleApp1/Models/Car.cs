using ConsoleApp1.Data;

namespace ConsoleApp1.Models{

    public enum Fuel
    {
        flex = 1, 
        gasolina = 2
    }   

    public class Car : Vehicle
    {

        public int Doors { get; set; }
        public Fuel Fuel { get; set; }
        public string Power { get; set; }

        public Car (
            DateOnly manufacturingDate,
            string name,
            string licensePlate,
            double value,
            string color,
            int doors, 
            Fuel fuel,
            string power
            ) : base(manufacturingDate, name, licensePlate, value, color)
        {
            Doors = doors; 
            Fuel = fuel; 
            Power = power; 
        }

        public void ShowInformation () {
            base.ListData();
            Console.WriteLine($"Portas: {Doors}");
            Console.WriteLine($"Combustível: {Fuel}");
            Console.WriteLine($"Potência: {Power} cavalos");
        }

        public override void SellVehicle(string cpf)
        {
            base.SellVehicle(cpf);
            Cars.SellCar(this);
        }
    }
}