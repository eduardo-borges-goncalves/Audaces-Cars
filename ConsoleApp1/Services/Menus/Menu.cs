
namespace ConsoleApp1.Services.Menus
{
    static class Menu
    {
        static public void FirstMenu()
        {
            Console.WriteLine("\n\n   MENU CENTRAL");
            Console.WriteLine("1 - Escolha uma opção:\n");
            Console.WriteLine("1 - Cadastrar Veículo");
            Console.WriteLine("2 - Vender Veículo");
            Console.WriteLine("3 - Listar Veículos");
            Console.WriteLine("4 - Veículos Vendidos Maior e Menor Preço");
            Console.WriteLine("5 - Histórico de Transações");
            Console.WriteLine("6 - Alterar cor ou valor");
            Console.WriteLine("s - Sair\n");
        }

        static public void Vehicle()
        {
            Console.WriteLine("\n\n1 - Carro");
            Console.WriteLine("2 - Moto ou Triciclo");
            Console.WriteLine("3 - Camionete\n");
        } 
        static public void VehicleColor()
        {
            Console.WriteLine("\n\n1 - Carro");
            Console.WriteLine("2 - Moto ou Triciclo");
        }
        static public void ListVehicle()
        {
            Console.WriteLine("\n\n1 - Carro");
            Console.WriteLine("2 - Moto ou Triciclo");
            Console.WriteLine("3 - Camionete");
            Console.WriteLine("4 - Todos\n");
        }

        static public void VehicleAvailability()
        {
            Console.WriteLine("\n\n1 - Todos");
            Console.WriteLine("2 - Disponíveis");
            Console.WriteLine("3 - Vendidos\n");
        }

        static public void UpdateVehicle()
        {
            Console.WriteLine("\n\n1 - Alterar Cor do veículo");
            Console.WriteLine("2 - Alterar Valor do veículo\n");
        }

        static public void FlexGasoline()
        {
            Console.WriteLine("\n1 - Flex");
            Console.WriteLine("2 - Gasolina\n");
        }
        static public void DieselGasoline()
        {
            Console.WriteLine("\n1 - Diesel");
            Console.WriteLine("2 - Gasolina\n");
        }

    }
}
