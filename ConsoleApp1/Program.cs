using ConsoleApp1.Data;
using ConsoleApp1.Services;
using ConsoleApp1.Services.Factories;
using ConsoleApp1.Services.Menus;
using ConsoleApp1.Services.Update;

FactoryVehicle.Car();
FactoryVehicle.Car();
FactoryVehicle.Car();
FactoryVehicle.Moto();
FactoryVehicle.Moto();
FactoryVehicle.Van();

var optionSelected = "s";
Console.WriteLine("Seja bem vindo ao DevInCar!");

do
{
    Menu.FirstMenu();

    optionSelected = Console.ReadKey().KeyChar.ToString().ToUpper();

    switch (optionSelected)
    {
        case "1":
            RegisterVehicle.ChooseVehicle();
            break;
        case "2":
            SellVehicle.ChooseVehicle();
            break;    
        case "3":
            ListVehicles.ChooseAvailability();
            break;
        case "4":
            BestSale.get();
            LowPriceSale.get();
            break;
        case "5":
            Transactions.GetTransactions();
            break;  
        case "6":
            UpdateVehicle.ChooseUpdate();
            break;    
        case "S":
            Console.WriteLine("opção S");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
} while (optionSelected != "S");

// enunms numero de rodas moto 