using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    static class Cars
    {

        static List<Car> list = new List<Car>();

        static public void addCar(Car car)
        {
            list.Add(car);
        }

        static public void getCars()
        {
            list.ForEach((car) =>
            {
                int index = list.FindIndex(item => item.id == car.id);
                Console.WriteLine("\n");
                Console.WriteLine(index);
                car.showInformation();
            });
        }
    }

}