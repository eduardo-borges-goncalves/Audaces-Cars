using ConsoleApp1.Data;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    internal class LowPriceSale
    {
        public static void get()
        {
            if (Transactions.transactions.Count == 0)
            {
                Console.WriteLine("\nNão há registros de vendas de veículo no momento.");
            }
            else
            {
                Vehicle lowPriceVehicle = Transactions.transactions[0].Vehicle;
                double lowPriceValue = Transactions.transactions[0].Vehicle.Value;

                Transactions.transactions.ForEach(transaction =>
                {
                    if (lowPriceValue > transaction.Vehicle.Value)
                    {
                        lowPriceValue = transaction.Vehicle.Value;
                        lowPriceVehicle = transaction.Vehicle;
                    }
                });

                Console.WriteLine("\n\nVeículo vendido com MENOR preço já registrado:\n");
                lowPriceVehicle.ListData();
            }
        }
    }
}
