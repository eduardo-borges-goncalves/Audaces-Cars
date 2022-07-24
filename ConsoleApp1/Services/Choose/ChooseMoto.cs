using ConsoleApp1.Models;
using ConsoleApp1.Data;

namespace ConsoleApp1.Services.Choose
{
    public static class ChooseMoto
    {
        public static Moto Moto()
        {
            int option;
            while (true)
            {
                Console.WriteLine("\nEscolha uma opção: ");
                Motos.GetAvailableMotos();
                option = int.Parse(Console.ReadLine());
                Console.WriteLine($"{option}");

                if (option > Motos.list.Count - 1 || option < 0)
                {
                    Console.WriteLine("\nOpção inválida");
                }
                else if (Motos.list[option].Status != "disponivel")
                {
                    Console.WriteLine("\nOpção inválida");
                }
                else break;
            }
            return Motos.list[option];
        }

    }
}
