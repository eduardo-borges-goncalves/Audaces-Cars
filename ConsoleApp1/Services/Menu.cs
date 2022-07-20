using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    static class Menu
    {
        static public void firstMenu()
        {
            Console.WriteLine("\n1 - Cadastrar Veículo");
            Console.WriteLine("2 - Vender Veículo");
            Console.WriteLine("3 - Listar Veículos");
            Console.WriteLine("4 - Veículos Vendidos");
            Console.WriteLine("5 - Veículos Disponíveis");
            Console.WriteLine("s - Sair");
        }

        static public void menuCreateVehicle()
        {
            Console.WriteLine("\n1 - Carro");
            Console.WriteLine("2 - Moto ou Triciclo");
            Console.WriteLine("3 - Camionete");
        }

    }
}
