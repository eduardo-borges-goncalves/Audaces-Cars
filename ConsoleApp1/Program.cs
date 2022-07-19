using ConsoleApp1.Models;


var date = new DateOnly(2022, 01, 05);

var firstVehicle = new Vehicle(date, "Honda", "NKC2864", 134000, "01101101101101", "White");

firstVehicle.BuyVehicle(7);
firstVehicle.ListData();