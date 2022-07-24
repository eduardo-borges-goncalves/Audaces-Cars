using System.Globalization;
using ConsoleApp1.Models;

namespace ConsoleApp1.Data
{
    public static class Transactions
    {

        public static List<Transaction> transactions = new();

        public static void AddTransaction(Transaction transaction)
        {
            transactions.Add(transaction);
        }

        public static void GetTransactions()
        {
            if (transactions.Count() == 0)
            {
                Console.WriteLine("\nAinda não há transações registradas.\n");
                return;
            }
            transactions.ForEach(transaction => {
                var index = transactions.FindIndex(i => i.Id ==transaction.Id);
                Console.WriteLine($"\nTransação {index +1}:\n");
                Console.WriteLine($"Veículo: {transaction.Vehicle.Name}");
                Console.WriteLine($"Placa: {transaction.Vehicle.LicensePlate}");
                Console.WriteLine($"CPF comprador: {transaction.Vehicle.Cpf}");
                Console.WriteLine($"Valor da venda: {transaction.Vehicle.Value.ToString("C3", CultureInfo.CurrentCulture)}");
                Console.WriteLine($"Data: {transaction.SellDate}\n");
            });
        }
    }
}
