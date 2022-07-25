using ConsoleApp1.Models;
using ConsoleApp1.Data;

namespace ConsoleApp1.Services.Choose
{
    public static class ChooseMoto
    {
        public static Moto Moto()
        {
            var validOption = false;
            int option = 0;
            while (!validOption)
            {
                try
                {
                    Console.WriteLine("\nEscolha uma opção: ");
                    Motos.GetAvailableMotos();
                    option = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{option}");

                    validOption = true;
                    return Motos.list[option];
                }
                catch (Exception)
                {
                    validOption = false;
                    Console.WriteLine("\nOpção inválida");
                }
            }
            return Motos.list[option];
        }
    }
}
