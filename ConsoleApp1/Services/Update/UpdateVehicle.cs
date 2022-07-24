using ConsoleApp1.Services.Menus;
using ConsoleApp1.Services.Validators;

namespace ConsoleApp1.Services.Update
{
    static public class UpdateVehicle
    {
        public static void ChooseUpdate()
        {
            Menu.UpdateVehicle();
            var option = Console.ReadKey().KeyChar;

            switch (option)
            {
                case '1':
                    ChooseVehicleColor();
                    break;
                case '2':
                    ChooseVehicleValue();
                    break;
                default:
                    Console.WriteLine("\nOpção inválida");
                    break;
            }
        }

        public static void ChooseVehicleColor()
        {
            while (true)
            {
                Menu.Vehicle();
                var option = Console.ReadKey().KeyChar;

                switch (option)
                {
                    case '1':
                        if (IsAvailable.Car())
                            UpdateColor.Car();
                        break;
                    case '2':
                        if (IsAvailable.Moto())
                            UpdateColor.Moto();
                        break;
                    case '3':
                        if (IsAvailable.Van())
                            UpdateColor.Van();
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida");
                        break;
                }
                break;
            }
        }

        public static void ChooseVehicleValue()
        {
            Menu.Vehicle();
            var option = Console.ReadKey().KeyChar;

            switch (option)
            {
                case '1':
                    if (IsAvailable.Car())
                        UpdateValue.Car();
                    break;
                case '2':
                    if (IsAvailable.Moto())
                        UpdateValue.Moto();
                    break;
                case '3':
                    if (IsAvailable.Van())
                        UpdateValue.Van();
                    break;
                default:
                    Console.WriteLine("\nOpção inválida");
                    break;
            }
        }

    }
}
