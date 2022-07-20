using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models;

namespace ConsoleApp1.Services
{
    static class RegisterVehicle
    {
        static private DateOnly date;
        static private string name;
        static private string licensePlate;
        static private double value;
        static private int doors;
        static private string fuel;
        static private string power;

        static public void chooseVehicle()
        {
            Menu.menuCreateVehicle();
            var option = Console.ReadKey().KeyChar;

            switch (option)
            {
                case '1':
                    registerCar();
                    break;
                case '2':
                    registerMoto();
                    break;
                case '3':
                    registerVan();
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }

        static void getCommonInformation()
        {
            Console.WriteLine("Insira a data de Fabricação conforme o seguinte modelo: 2022, 01, 05");
            date = DateOnly.Parse(Console.ReadLine());

            Console.WriteLine("Insira o nome:");
            name = Console.ReadLine();

            Console.WriteLine("Insira a Placa:");
            licensePlate = Console.ReadLine();

            Console.WriteLine("Insira o valor do veículo:");
            value = double.Parse(Console.ReadLine());
        }

        static void getCarVanInformation()
        {
            Console.WriteLine("Insira o número de portas:");
            doors = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a potência:");
            power = Console.ReadLine();

            Console.WriteLine("É flex ou gasolina?");
            fuel = Console.ReadLine();
        }

        static public void registerCar()
        {
            getCommonInformation();
            getCarVanInformation();

            Console.WriteLine("Insira a cor:");
            var color = Console.ReadLine();

            var newCar = new Car(
                date,
                name,
                licensePlate,
                value,
                color,
                doors,
                fuel,
                power);
            Console.WriteLine("Carro cadastrado com sucesso!\n");
            newCar.showInformation();
            Cars.addCar(newCar);
        }

        static public void registerMoto()
        {
            getCommonInformation();
          
            Console.WriteLine("Insira o número de rodas");
            var wheels = Console.ReadLine();

            Console.WriteLine("Insira a potência:");
            var power = Console.ReadLine();

        }

        static public void registerVan()
        {
            getCommonInformation();
            getCarVanInformation();
           
            Console.WriteLine("Insira a capacidade da caçamba em litros:");
            var bucketCapacity = int.Parse(Console.ReadLine());
        }
    }
}

//DateOnly manufacturingDate,
//            string name,
//            string licensePlate,
//            double value,
//            string color


