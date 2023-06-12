using System;

namespace _Teste04

{
    class Program
    {
        static void Main(string[] args)
        {
            Resgate r = new Resgate();
            Console.WriteLine("Qual o valor investido?");
            r.valorPresente = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual a taxa de juros aplicada?");
            r.taxa = Convert.ToDouble(Console.ReadLine());
            r.taxa/= 100;
            r.tabela();
        }

    }

}