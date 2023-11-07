using System;

namespace ConverterTemperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temp_origem;
            double temp_destino;
            int op;

            Console.WriteLine("Qual tipo de temperatura deseja converter");
            Console.WriteLine("1 - Celsius");
            Console.WriteLine("2 - Farenheint");
            
            op = Convert.ToInt32(Console.ReadLine());
            if (op == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Favor digitar temperatura em Celsius");

                temp_origem = Convert.ToDouble(Console.ReadLine());
                temp_destino = (temp_origem * 1.8) + 32;

                Console.WriteLine();
                Console.WriteLine("Convertido é "+ temp_destino + " Farenheint");
            } 
            else
            {
                Console.WriteLine();
                Console.WriteLine("Favor digitar temperatura em Farenheint");

                temp_origem = Convert.ToDouble(Console.ReadLine());
                temp_destino = ((temp_origem * 9) / 5) + 32;

                Console.WriteLine();
                Console.WriteLine("Convertido é " + temp_destino + " Celsius");
            }

        }
    }
}
