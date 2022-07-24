using System.Text.RegularExpressions;

namespace ConsoleApp1.Services.Validators
{
    public static class ValidaCPF
    {
        public static bool IsValid(string cpf)
        {
            if (cpf.Length != 11) return false;
            if (!Regex.IsMatch(cpf, @"^\d+$")) return false;
            else return true;
        }

        static public string GetCpf()
        {
            var cpf = "";
            while (!IsValid(cpf))
            {
                Console.WriteLine("Insira um CPF válido com 11 dígitos");
                cpf = Console.ReadLine();
                if (!IsValid(cpf)) Console.Write("CPF inválido. ");
            }
            return cpf;
        }
    }
}
