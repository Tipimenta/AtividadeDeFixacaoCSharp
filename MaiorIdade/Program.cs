using System;

namespace Maior_idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maiorIdade = 18;

            Console.WriteLine("Favor digitar o ano de nascimento");
            int anoNascimento = Convert.ToInt32(Console.ReadLine());

            int idadeAtual = DateTime.Now.Year - anoNascimento;
            Console.WriteLine(idadeAtual);

            if(idadeAtual >= maiorIdade)
            {
                Console.WriteLine("Pessoa maior de idade");
            }
            else
            {
                Console.WriteLine("Pessoa menor de idade");
            }

            Console.ReadKey();
        }
    }
}
