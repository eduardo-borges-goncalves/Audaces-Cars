using ConsoleApp1.Data;

namespace ConsoleApp1.Services.Validators
{
    public static class IsAvailable
    {
        static private int disponivel;
        public static bool Car()
        {
            disponivel = Cars.list.FindIndex(i => i.Status == "disponivel");
            if (disponivel == -1)
            {
                Console.WriteLine("\nNão há carros disponíveis no momento");
                return false;
            }
            return true;
        }
        public static bool Moto()
        {
            disponivel = Motos.list.FindIndex(i => i.Status == "disponivel");
            if (disponivel == -1)
            {
                Console.WriteLine("\nNão há motos disponíveis no momento");
                return false;
            }
            return true;
        }
        public static bool Van()
        {
            disponivel = Vans.list.FindIndex(i => i.Status == "disponivel");
            if (disponivel == -1)
            {
                Console.WriteLine("\nNão há camionetes disponíveis no momento");
                return false;
            }
            return true;
        }
    }
}
