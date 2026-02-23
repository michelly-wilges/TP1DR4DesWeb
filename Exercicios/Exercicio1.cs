using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1DR4DesWeb.Exercicios
{
    internal class Exercicio1
    {
        public delegate decimal CalculateDiscount(decimal precoOriginal);
        public static decimal AplicarDesconto10(decimal preco)
        {
            return preco - (preco * 0.10m);
        }
        public static void Executar()
        {
            Console.Write("Informe o preço original: ");
            decimal precoOriginal = decimal.Parse(Console.ReadLine());

            CalculateDiscount desconto = AplicarDesconto10;

            decimal precoFinal = desconto(precoOriginal);

            Console.WriteLine($"Preço com desconto: {precoFinal:F2}");
        }
    }
}
