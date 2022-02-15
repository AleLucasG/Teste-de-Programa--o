using System;

namespace Teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Escreva um programa que imprima as estações do ano por escolhas numericas: (1, 1 2 3 4 5 6 7 8 9 10) (2, 1 2 3 4 5 6 7 8 9 10) (3, 1 2 3 4 5 6 7 8 9 10) 
             * (4, 1 2 3 4 5 6 7 8 9 10) assim sucessivamente, até que o primeiro número (antes da vírgula), também chegue a 10
            */

            // 1° inicialização, 2° condição e 3° incremeto.

            for (int i = 1; i <= 10; i = i + 1)
            {
                Console.WriteLine("(" + i + ", 1 2 3 4 5 6 7 8 9 10)");
            }
        }
    }
}
