using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1DR4DesWeb.Exercicios
{
    internal class Exercicio2
    {
        public static void Executar()
        {
            Console.WriteLine($@"
            Idioma de exibição 

                    1  - Português
                    2  - English
                    3  - Español

            Digite o número do idioma: ");

            if (!int.TryParse(Console.ReadLine(), out int escolha))
            {
                escolha = -1;
            } 

            Action<string> mensagem = null;

            switch (escolha)
            {
                case 1:
                    mensagem = MensagemPortugues;
                    break;
                case 2:
                    mensagem = MensagemIngles;
                    break;
                case 3:
                    mensagem = MensagemEspanhol;
                    break;
                default:
                    Console.WriteLine("Opção inválida, digite novamente.");
                    break;
            }

            mensagem?.Invoke(escolha switch
            {
                1 => "Bem-vindo!",
                2 => "Welcome!",
                3 => "Bienvenido!",
            });
        }

        static void MensagemPortugues(string msg) => Console.WriteLine(msg);
        static void MensagemIngles(string msg) => Console.WriteLine(msg);
        static void MensagemEspanhol(string msg) => Console.WriteLine(msg);
    }
}