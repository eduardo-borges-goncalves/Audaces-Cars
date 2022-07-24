using ConsoleApp1.Models;
using ConsoleApp1.Data;

namespace ConsoleApp1.Services.Choose
{
    public static class ChooseVan
    {
        public static Van Van()
        {
            int option;
            while (true)
            {
                Console.WriteLine("\nEscolha uma opção: ");
                Vans.GetAvailableVans();
                option = int.Parse(Console.ReadLine());
                Console.WriteLine($"{option}");

                if (option > Vans.list.Count - 1 || option < 0)
                {
                    Console.WriteLine("\nOpção inválida");
                }
                else if (Vans.list[option].Status != "disponivel")
                {
                    Console.WriteLine("\nOpção inválida");
                }
                else break;
            }
            return Vans.list[option];
        }

    }
}
