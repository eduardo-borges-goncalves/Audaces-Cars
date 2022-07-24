using ConsoleApp1.Models;

namespace ConsoleApp1.Data
{
    static class Vans
    {
        static public List<Van> list = new List<Van>();
        static private List<Van> selled = new List<Van>();

        static public void AddVan(Van van)
        {
            list.Add(van);
        }

        static public void SellVan(Van van)
        {
            selled.Add(van);
        }

        static public void DisplayVan(Van van)
        {
            int index = list.FindIndex(item => item.Chassis == van.Chassis);
            Console.WriteLine($"\n{index}");
            van.ShowInformation();
        }

        static public void GetVans()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("\nNenhuma camionete cadastrada até o momento.\n");
                return;
            }
            list.ForEach((van) => DisplayVan(van));
        }

        static public void GetAvailableVans()
        {
            var available = false;
            list.ForEach((van) =>
            {
                if (van.Status == "disponivel")
                {
                    int index = list.FindIndex(item => item.Chassis == van.Chassis);
                    Console.WriteLine($"\nOpção {index}:");
                    van.ShowInformation();
                    available = true;
                }
            });

            if (!available) Console.WriteLine("Nenhuma camionete disponível no momento.");
        }
        static public void GetSelledVans()
        {
            if (selled.Count == 0)
            {
                Console.WriteLine("\nNenhuma camionete vendida até o momento.\n");
                return;
            }
            selled.ForEach((van) => DisplayVan(van));
        }
    }

}