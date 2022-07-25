using ConsoleApp1.Data;
using ConsoleApp1.Models;

namespace ConsoleApp1.Services.Factories
{
    static public class FactoryVehicle
    {
        public static void Car(string nome, string placa)
        {
            Car honda = new Car(
                new DateOnly(2022, 05, 06),
                nome, 
                placa,
                134567,
                "white",
                4,
                Fuel.gasolina,
                "104");
            Cars.AddCar(honda);
        }

        public static void Moto()
        {
            Moto twister = new Moto(new DateOnly(2022, 05, 06), "twister", "npj7898", 13567, "white", 2, "104");
            Motos.AddMoto(twister);
        }

        public static void Van()
        {
            Van hilux = new Van(
                new DateOnly(2022, 05, 06),
                "hilux",
                "npj7898",
                334567, 
                4,
                560,
                FuelVan.diesel,
                "104");
            Vans.AddVan(hilux);
        }
    }
}
