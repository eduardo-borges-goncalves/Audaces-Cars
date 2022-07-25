using ConsoleApp1.Models;
using ConsoleApp1.Data;

namespace ConsoleApp1.Services.Choose
{
    public static class ChooseVan
    {
        public static Van Van()
        {
            var validOption = false;
            int option = 0;
            while (!validOption)
            {
                try
                {
                    Console.WriteLine("\nEscolha uma opção: ");
                    Vans.GetAvailableVans();
                    option = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{option}");

                    validOption = true;
                    return Vans.list[option];
                }
                catch (Exception)
                {
                    validOption = false;
                    Console.WriteLine("\nOpção inválida");

                }
            }
            return Vans.list[option];
        }
    }
}