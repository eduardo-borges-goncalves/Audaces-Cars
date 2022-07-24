using ConsoleApp1.Data;
using ConsoleApp1.Models;
using ConsoleApp1.Services.Choose;
using ConsoleApp1.Services.Menus;
using ConsoleApp1.Services.Validators;

namespace ConsoleApp1.Services
{
    static class SellVehicle
    {
        static public void ChooseVehicle()
        {
            while(true)
            {
                Menu.Vehicle();
                char option = Console.ReadKey().KeyChar;

                switch (option)
                {
                    case '1':
                        if(IsAvailable.Car())
                            SellCar();
                        break;
                    case '2':
                        if (IsAvailable.Moto())
                            SellMoto();
                        break;
                    case '3':
                        if (IsAvailable.Van())
                            SellVan();
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida");
                        break;
                }
                break;
            } 
        }

        static public void SellCar()
        {
            var car = ChooseCar.Car();
            var cpf = ValidaCPF.GetCpf();
            car.SellVehicle(cpf);

            var newTransaction = new Transaction(car, DateOnly.FromDateTime(DateTime.Now));
            Transactions.AddTransaction(newTransaction);

            Console.WriteLine("\nCarro vendido com Sucesso!\n");
        }

        static public void SellMoto()
        {
            var selled = ChooseMoto.Moto();
            var cpf = ValidaCPF.GetCpf();
            selled.SellVehicle(cpf);

            var newTransaction = new Transaction(selled, DateOnly.FromDateTime(DateTime.Now));
            Transactions.AddTransaction(newTransaction);

            Console.WriteLine("\nMoto vendida com Sucesso!\n");
        }
        static public void SellVan()
        {
            var selled = ChooseVan.Van();
            var cpf = ValidaCPF.GetCpf();
            selled.SellVehicle(cpf);

            var newTransaction = new Transaction(selled, DateOnly.FromDateTime(DateTime.Now));
            Transactions.AddTransaction(newTransaction);

            Console.WriteLine("\nCamionete vendida com Sucesso!\n");
        }
    }
}
