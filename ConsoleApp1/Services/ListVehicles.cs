
using ConsoleApp1.Data;
using ConsoleApp1.Services.Menus;

namespace ConsoleApp1.Services
{
    static public class ListVehicles
    {
        static private Boolean invalid = false;

        static public void ChooseAvailability()
        {
            do
            {
                Menu.VehicleAvailability();
                var option = Console.ReadKey().KeyChar;

                switch (option)
                {
                    case '1':
                        ChooseVehicleAll();
                        break;
                    case '2':
                        ChooseVehicleAvailable();
                        break;
                    case '3':
                        ChooseVehicleSelled();
                        break;
                    default:
                        invalid = true;
                        Console.WriteLine("\nOpção inválida");
                        break;
                }
            } while (invalid);
        }

        static public void ChooseVehicleAll()
        {
            do
            {
                Menu.ListVehicle();
                var option = Console.ReadKey().KeyChar;

                switch (option)
                {
                    case '1':
                        Console.WriteLine("\n\nLista de Carros:\n");
                        Cars.GetCars();
                        break;
                    case '2':
                        Console.WriteLine("\n\nLista de Motos:\n");
                        Motos.GetMotos();
                        break;
                    case '3':
                        Console.WriteLine("\n\nLista de Camionetes:\n");
                        Vans.GetVans();
                        break;
                    case '4':
                        Console.WriteLine("\n\nLista com todos os veículos:");
                        Console.WriteLine("\nCarros:");
                        Cars.GetCars();
                        Console.WriteLine("\nMotos:");
                        Motos.GetMotos();
                        Console.WriteLine("\nCamionetes:");
                        Vans.GetVans();
                        break;
                    default:
                        invalid = true;
                        Console.WriteLine("\nOpção inválida");
                        break;
                }
            } while (invalid);
        }     
        
        static public void ChooseVehicleAvailable()
        {
            do
            {
                Menu.ListVehicle();
                var option = Console.ReadKey().KeyChar;

                switch (option)
                {
                    case '1':
                        Console.WriteLine("\n\nLista de Carros:\n");
                        Cars.GetAvailableCars();
                        break;
                    case '2':
                        Console.WriteLine("\n\nLista de Motos:\n");
                        Motos.GetAvailableMotos();
                        break;
                    case '3':
                        Console.WriteLine("\n\nLista de Camionetes:\n");
                        Vans.GetAvailableVans();
                        break;
                    default:
                        invalid = true;
                        Console.WriteLine("\nOpção inválida");
                        break;
                }
            } while (invalid);
        }    
        
        static public void ChooseVehicleSelled()
        {
            do
            {
                Menu.ListVehicle();
                var option = Console.ReadKey().KeyChar;

                switch (option)
                {
                    case '1':
                        Console.WriteLine("\n\nLista de Carros:\n");
                        Cars.GetSelledCars();
                        break;
                    case '2':
                        Console.WriteLine("\n\nLista de Motos:\n");
                        Motos.GetSelledMotos();
                        break;
                    case '3':
                        Console.WriteLine("\n\nLista de Camionetes:\n");
                        Vans.GetSelledVans();
                        break;
                    default:
                        invalid = true;
                        Console.WriteLine("\nOpção inválida");
                        break;
                }
            } while (invalid);
        }

    }
}
