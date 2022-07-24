using ConsoleApp1.Services.Choose;

namespace ConsoleApp1.Services.Update
{
    static public class UpdateValue
    {
        public static void Car()
        {
            var car = ChooseCar.Car();
            Console.WriteLine("Insira o novo valor do veículo:");
            var value = int.Parse(Console.ReadLine());

            car.UpdateValue(value);
            Console.WriteLine("\nValor do carro atualizado com sucesso:\n");
            car.ListData();
        }
        public static void Moto()
        {
            var moto = ChooseMoto.Moto();
            Console.WriteLine("Insira o novo valor do veículo:");
            var value = int.Parse(Console.ReadLine());

            moto.UpdateValue(value);
            Console.WriteLine("\nValor da moto atualizado com sucesso:\n");
            moto.ListData();
        }
        public static void Van()
        {
            var van = ChooseVan.Van();
            Console.WriteLine("Insira o novo valor do veículo:");
            var value = int.Parse(Console.ReadLine());

            van.UpdateValue(value);
            Console.WriteLine("\nValor da camionete atualizado com sucesso:\n");
            van.ListData();
        }
    }
}
