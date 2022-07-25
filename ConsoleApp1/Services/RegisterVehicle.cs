using ConsoleApp1.Data;
using ConsoleApp1.Models;
using ConsoleApp1.Services.Menus;

namespace ConsoleApp1.Services
{
    static class RegisterVehicle
    {
        static private DateOnly Date { get; set; }
        static private string Name { get; set; }
        static private string LicensePlate { get; set; }
        static private double Value { get; set; }
        static private int Doors { get; set; }
        static private string Power { get; set; }

        static public void ChooseVehicle()
        {
            Menu.Vehicle();
            var option = Console.ReadKey().KeyChar;

            switch (option)
            {
                case '1':
                    RegisterCar();
                    break;
                case '2':
                    RegisterMoto();
                    break;
                case '3':
                    RegisterVan();
                    break;
                default:
                    Console.WriteLine("\nOpção inválida");
                    break;
            }
        }

        static void GetCommonInformation()
        {
            var validData = false;
            while (!validData)
            {
                try
                {
                    Console.WriteLine("\n\nInsira a data de Fabricação conforme o seguinte modelo: 2022 01 05 ou 2022-05-06");
                    Date = DateOnly.Parse(Console.ReadLine());
                    validData = true;
                }
                catch (Exception)
                {
                    validData = false;
                    Console.WriteLine("Data inválida");
                }
            }

            Console.WriteLine("Insira o nome:");
            Name = Console.ReadLine();

            Console.WriteLine("Insira a Placa:");
            LicensePlate = Console.ReadLine();


            Console.WriteLine("Insira o valor do veículo:");
            Value = double.Parse(Console.ReadLine());
        }

        static void GetCarVanCommonInformation()
        {
            Console.WriteLine("Insira o número de portas:");
            Doors = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a potência:");
            Power = Console.ReadLine();
        }

        static public void RegisterCar()
        {
            try
            {
                GetCommonInformation();
                GetCarVanCommonInformation();

                Console.WriteLine("É flex ou gasolina?");
                Menu.FlexGasoline();
                var fuel = Enum.Parse<Fuel>(Console.ReadLine());

                Console.WriteLine("Insira a cor:");
                var color = Console.ReadLine();

                var newCar = new Car(
                    Date,
                    Name,
                    LicensePlate,
                    Value,
                    color,
                    Doors,
                    fuel,
                    Power);

                Console.WriteLine("\nCarro cadastrado com sucesso!\n");
                newCar.ShowInformation();
                Cars.AddCar(newCar);
            }
            catch (Exception)
            {
                Console.WriteLine("\nDados inválidos. \nOperação cancelada");
            }
        }

        static public void RegisterMoto()
        {
            try
            {
                GetCommonInformation();

                Console.WriteLine("Insira a cor:");
                var color = Console.ReadLine();

                Console.WriteLine("Insira o número de rodas:");
                var wheels = int.Parse(Console.ReadLine());

                Console.WriteLine("Insira a potência:");
                var Power = Console.ReadLine();

                var newMoto = new Moto(
                    Date,
                    Name,
                    LicensePlate,
                    Value,
                    color,
                    wheels,
                    Power
                    );

                Console.WriteLine("\nMoto cadastrada com sucesso!\n");
                newMoto.ShowInformation();
                Motos.AddMoto(newMoto);
            }
            catch (Exception)
            {
                Console.WriteLine("\nDados inválidos. \nOperação cancelada");
            }
        }

        static public void RegisterVan()
        {
            try
            {
                GetCommonInformation();
                GetCarVanCommonInformation();

                Console.WriteLine("É diesel ou gasolina?");
                Menu.DieselGasoline();
                var fuel = Enum.Parse<FuelVan>(Console.ReadLine());

                Console.WriteLine("Insira a capacidade da caçamba em litros:");
                var bucketCapacity = int.Parse(Console.ReadLine());

                var newVan = new Van(
                    Date,
                    Name,
                    LicensePlate,
                    Value,
                    Doors,
                    bucketCapacity,
                    fuel,
                    Power
                    );

                Console.WriteLine("\nCamionete cadastrada com sucesso!\n");
                newVan.ShowInformation();
                Vans.AddVan(newVan);
            }
            catch (Exception)
            {
                Console.WriteLine("\nDados inválidos. \nOperação cancelada");
            }
        }
    }
}



