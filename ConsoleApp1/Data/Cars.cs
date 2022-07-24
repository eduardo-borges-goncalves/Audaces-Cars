using ConsoleApp1.Models;

namespace ConsoleApp1.Data
{
    static class Cars
    {
        static public List<Car> list = new();
        static private List<Car> selled = new();

        static public void AddCar(Car car)
        {
            list.Add(car);
        }

        static public void SellCar(Car car)
        {
            selled.Add(car);
        }

        static public void DisplayCar(Car car)
        {
            int index = list.FindIndex(item => item.Chassis == car.Chassis);
            Console.WriteLine($"\n{index}");
            car.ShowInformation();
        }

        static public void GetCars()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("\nNenhum carro cadastrado até o momento.\n");
                return;
            }
            list.ForEach((car) => DisplayCar(car));
        }

        static public void GetAvailableCars()
        {
            var available = false;

            list.ForEach((car) =>
            {
                if (car.Status == "disponivel")
                {
                    int index = list.FindIndex(item => item.Chassis == car.Chassis);
                    Console.WriteLine($"\nOpção {index}:");
                    car.ShowInformation();
                    available = true;
                } 
            });

            if (!available) Console.WriteLine("\nNenhum carro disponível no momento.\n");
        }
        static public void GetSelledCars()
        {
            if (selled.Count == 0)
            {
                Console.WriteLine("\nNenhum carro vendido até o momento.\n");
                return;
            }
            selled.ForEach((car) => DisplayCar(car));
        }
    }

}