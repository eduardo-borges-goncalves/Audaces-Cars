using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models{
    public class Cars 
    {
        List<Car> cars = new List<Car>();

        public void addCar (Car car) {
            cars.add(car);
        }

        public List<Car> getCars () {
            cars.foreach(car => Console.WriteLine(car));
        }
    }
}