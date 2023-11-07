using System;
using System.Text.RegularExpressions;


namespace ValidarSenha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Crie um programa que peça para que o usuário 
            informe uma senha. Depois de informar a senha
            o sistema deve validar se a senha tem mais de 8 caracteres
            , uma letra maiúscula, uma letra minúscula e um numero.
            Informe se é valida ou não.
            */

            Console.WriteLine("Favor digite a senha");
            Console.WriteLine();
            Console.WriteLine("- Deve conter mínimo 8 caracteres");
            Console.WriteLine("- Deve ter ao menos uma letra Maiúscula");
            Console.WriteLine("- Deve ter um letra Minúscula");
            Console.WriteLine("- Deve ter um número");
            Console.WriteLine();

            var senha = Console.ReadLine();
            bool ok = true;
            string maiscula = @"^(?=.*[A-Z])";
            string miniscula = @"^(?=.*[a-z])";
            string numero = @"^(?=.*\d)";

            Console.WriteLine();

            Regex m = new Regex(maiscula);
            Regex min = new Regex(miniscula);
            Regex num = new Regex(numero);

            if (senha.Length < 8)
            {
                Console.WriteLine("Números de caracteres insuficientes");
                ok = false;
            }
            if (!m.IsMatch(senha))
            {
                Console.WriteLine("Sua senha não possui caracter maisculo");
                ok = false;
            }
            if (!min.IsMatch(senha))
            {
                Console.WriteLine("Sua senha não possui caracter minisculo");
                ok = false;
            }
            if (!num.IsMatch(senha))
            {
                Console.WriteLine("Sua senha não possui numeros");
                ok = false;
            }
            if (ok)
            {
                Console.WriteLine("Sua senha está ok");
            }
            Console.ReadKey();
        }
    }
}
