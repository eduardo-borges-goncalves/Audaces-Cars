using ConsoleApp1.Models;
using ConsoleApp1.Data;

namespace ConsoleApp1.Services.Choose
{
    public static class ChooseCar
    {
        public static Car Car()
        {
            var validOption = false;
            int option = 0;
            while (!validOption)
            {
                try
                {
                    Console.WriteLine("\nEscolha uma opção: ");
                    Cars.GetAvailableCars();
                    option = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{option}");

                    validOption = true;
                    return Cars.list[option];
                } 
                catch (Exception)
                {
                    validOption = false;
                    Console.WriteLine("\nOpção inválida");
                }
            }
            return Cars.list[option];
        }
    }
}
