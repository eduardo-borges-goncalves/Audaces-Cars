using ConsoleApp1.Models;
using ConsoleApp1.Data;

namespace ConsoleApp1.Services.Choose
{
    public static class ChooseCar
    {
        public static Car Car()
        {
            int option;
            while (true)
            {
                Console.WriteLine("\nEscolha uma opção: ");
                Cars.GetAvailableCars();
                option = int.Parse(Console.ReadLine());
                Console.WriteLine($"{option}");

                if (option > Cars.list.Count - 1 || option < 0)
                {
                    Console.WriteLine("\nOpção inválida");
                }
                else if (Cars.list[option].Status != "disponivel")
                {
                    Console.WriteLine("\nOpção inválida");
                }
                else break;
            }
            return Cars.list[option];
        }

    }
}
