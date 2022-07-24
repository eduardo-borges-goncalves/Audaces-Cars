using ConsoleApp1.Services.Choose;

namespace ConsoleApp1.Services.Update
{
    static public class UpdateColor
    {
        public static void Car()
        {
            var car = ChooseCar.Car();
            Console.WriteLine("Insira a nova cor do veículo:");
            var color = Console.ReadLine();

            car.UpdateColor(color);
            Console.WriteLine("\nCor do carro atualizada com sucesso:\n");
            car.ListData();
        }
        public static void Moto()
        {
            var moto = ChooseMoto.Moto();
            Console.WriteLine("Insira a nova cor do veículo:");
            var color = Console.ReadLine();

            moto.UpdateColor(color);
            Console.WriteLine("\nCor da moto atualizada com sucesso:\n");
            moto.ListData();
        }
        public static void Van()
        {
            var van = ChooseVan.Van();
            Console.WriteLine("Insira a nova cor do veículo:");
            var color = Console.ReadLine();

            van.UpdateColor(color);
            Console.WriteLine("\nCor da camionete atualizada com sucesso:\n");
            van.ListData();
        }
    }
}
