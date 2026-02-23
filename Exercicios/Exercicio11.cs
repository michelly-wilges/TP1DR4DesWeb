using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1DR4DesWeb.Exercicios
{
    internal class Exercicio11
    {
        public static void Executar()
        {
            Func<string, string, string> transformacoes = ConcatenarNomeSobrenome;
            transformacoes += ConverterParaMaiusculas;
            transformacoes += RemoverEspacos;

            string resultado = transformacoes("Michelly", "Wilges");

            Console.WriteLine("Resultado final: ");
            Console.WriteLine(resultado);
        }

        static string ConcatenarNomeSobrenome(string nome, string sobrenome)
        {
            string valor = $"{nome} {sobrenome}";
            Console.WriteLine($"Concatenar: {valor}");
            return valor;
        }

        static string ConverterParaMaiusculas(string nome, string sobrenome)
        {
            string valor = $"{nome} {sobrenome}".ToUpper();
            Console.WriteLine($"Maiúsculas: {valor}");
            return valor;
        }

        static string RemoverEspacos(string nome, string sobrenome)
        {
            string valor = $"{nome}{sobrenome}";
            Console.WriteLine($"Sem espaços: {valor}");
            return valor;
        }
    }
}