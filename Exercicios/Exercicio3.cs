using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1DR4DesWeb.Exercicios
{
    internal class Exercicio3
    {
        public static void Executar()
        {   Console.Write("Digite o valor da base do retângulo em cm: ");
            double baseRetangulo = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da altura do retângulo em cm: ");
            double alturaRetangulo = double.Parse(Console.ReadLine());
            
            Func<double, double, double> calcularArea = (b, h) => b * h;
            double area = calcularArea(baseRetangulo, alturaRetangulo);
            Console.WriteLine($"A área do retêngulo de base {baseRetangulo}cm e altura {alturaRetangulo}cm é: {area:F2}cm2");
        }
    }
}
