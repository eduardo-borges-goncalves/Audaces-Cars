using ConsoleApp1.Data;
using ConsoleApp1.Models;

namespace ConsoleApp1.Services
{
    static public class BestSale
    {
        public static void get()
        {
            if (Transactions.transactions.Count == 0)
            {
                Console.WriteLine("\nNão há registros de vendas de veículo no momento.");
            }
            else
            {
                Vehicle bestSale = Transactions.transactions[0].Vehicle;
                double bestSaleValue = Transactions.transactions[0].Vehicle.Value;

                Transactions.transactions.ForEach(transaction =>
                {
                    if (bestSaleValue < transaction.Vehicle.Value)
                    {
                        bestSaleValue = transaction.Vehicle.Value;
                        bestSale = transaction.Vehicle;
                    }
                });

                Console.WriteLine("\n\nVeículo vendido com MAIOR preço já registrado:\n");
                bestSale.ListData();
            }
        }
    }
}
