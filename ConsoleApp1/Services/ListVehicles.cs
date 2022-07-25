
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
                        invalid = false;
                        break;
                    case '2':
                        Console.WriteLine("\n\nLista de Motos:\n");
                        Motos.GetMotos();
                        invalid = false;
                        break;
                    case '3':
                        Console.WriteLine("\n\nLista de Camionetes:\n");
                        Vans.GetVans();
                        invalid = false;
                        break;
                    case '4':
                        Console.WriteLine("\n\nLista com todos os veículos:");
                        Console.WriteLine("\nCarros:");
                        Cars.GetCars();
                        Console.WriteLine("\nMotos:");
                        Motos.GetMotos();
                        Console.WriteLine("\nCamionetes:");
                        Vans.GetVans();
                        invalid = false;
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
                        invalid = false;
                        break;
                    case '2':
                        Console.WriteLine("\n\nLista de Motos:\n");
                        Motos.GetAvailableMotos();
                        invalid = false;
                        break;
                    case '3':
                        Console.WriteLine("\n\nLista de Camionetes:\n");
                        Vans.GetAvailableVans();
                        invalid = false;
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
                        invalid = false;
                        break;
                    case '2':
                        Console.WriteLine("\n\nLista de Motos:\n");
                        Motos.GetSelledMotos();
                        invalid = false;
                        break;
                    case '3':
                        Console.WriteLine("\n\nLista de Camionetes:\n");
                        Vans.GetSelledVans();
                        invalid = false;
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
