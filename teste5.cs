using System;

namespace Teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Escreva um programa que imprima as estações do ano por escolhas de numericas
            */

            int estacao = 2;

            switch (estacao)
            {
                case 1:
                    Console.WriteLine("Primavera - De 23 de Setembro à 21 de Dezembro");
                    break;
                case 2:
                    Console.WriteLine("Verão - De 21 de Dezembro à 21 de Março");
                    break;
                case 3:
                    Console.WriteLine("Outono - De 21 de Março à 21 de Junho");
                    break;
                case 4:
                    Console.WriteLine("Inverno - De 21 de Junho à 23 de Setembro ");
                    break;
                default:
                    Console.WriteLine("Estação Invalida");
                    break;
            }
            Console.ReadLine();


        }
    }
}
