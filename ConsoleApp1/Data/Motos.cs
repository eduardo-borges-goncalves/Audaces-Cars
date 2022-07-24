using ConsoleApp1.Models;

namespace ConsoleApp1.Data
{
    static public class Motos
    {
        static public List<Moto> list = new();
        private static List<Moto> selled = new();

        static public void AddMoto(Moto moto)
        {
            list.Add(moto);
        }  

        static public void SellMoto(Moto moto)
        {
            selled.Add(moto);
        }

        static public void DisplayMoto(Moto moto)
        {
            int index = list.FindIndex(item => item.Chassis == moto.Chassis);
            Console.WriteLine($"\n{index}");
            moto.ShowInformation();
        }
        static public void GetMotos ()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("\nNenhuma moto cadastrada até o momento.\n");
                return;
            }
            list.ForEach(moto => DisplayMoto(moto));
        }

        static public void GetAvailableMotos()
        {
            var available = false;
            list.ForEach(moto =>
            {
                if (moto.Status == "disponivel")
                {
                    int index = list.FindIndex(item => item.Chassis == moto.Chassis);
                    Console.WriteLine($"\nOpção {index}:");
                    moto.ShowInformation();
                    available = true;
                }
            });

            if (!available) Console.WriteLine("Nenhuma moto disponível no momento.");
        }

        static public void GetSelledMotos()
        {
            if (selled.Count == 0)
            {
                Console.WriteLine("\nNenhuma moto vendida até o momento.\n");
                return;
            }
            selled.ForEach(moto => DisplayMoto(moto));
        }

    }
}
