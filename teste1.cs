using System;

namespace Teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Uma revendedora de carros usados paga a seus funcionários vendedores um salário fixo por mês, mais uma comissão também 
             * fixa para cada carro vendido e mais 5% do valor das vendas efetuadas pelo vendedor. Escrever um programa que leia:
             * - salário fixo,
             * - o número de carros vendidos por cada vendedor,
             * - comissão fixa para cada carro vendido
             * - e o valor que ele recebe por carro vendido. 
             * - Calcule e escreva o salário final do vendedor.
            */

            string nome;
            Console.Write("Nome do vendedor: ");
            nome = Console.ReadLine();
            Console.WriteLine(" ");

            double salario; //salario fixo
            Console.Write("Salario base vendedor de carros R$ ");
            salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            int carrosVendidos; //n° carros vendidos por cada vendedor
            Console.Write("Quantidade de carros vendidos: ");
            carrosVendidos = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(" ");

            double comissaoFixa = 350; //comissão fixa para cada carro vendido
            comissaoFixa = comissaoFixa * carrosVendidos;
            Console.WriteLine("R$ 350,00 reais de comissão fixa por cada carro vendido. Com a venda dos " +carrosVendidos + " carros, você recebeu uma comissão fixa de " + String.Format("{0:c}", comissaoFixa));
            Console.WriteLine(" ");

            double comissaoExtra = 5; //e mais 5% do valor das vendas por efetuadas pelo vendedor
            comissaoExtra = (comissaoFixa / 100) * comissaoExtra;
            Console.WriteLine("O total de comissão extra sobre a comissão fixa é de 5% e você receberá " + String.Format("{0:C}", comissaoExtra));
            Console.WriteLine(" ");

            double valorTotalVendas;
            valorTotalVendas = (salario + comissaoFixa + comissaoExtra);
            Console.WriteLine("Seu salario R$ " + salario + " reais, somados as comissões fixas e extras, da um total de " + String.Format("{0:C}", valorTotalVendas));


        }
    }
}
