using TP1DR4DesWeb.Exercicios;

namespace TP1DR4DesWeb
{
    internal class Program
    {
        public delegate void ExecutarExercicio();

        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.Clear();
                Console.WriteLine($@"
                =================================================================
                       TP1 - Desenvolvimento Web com .NET e Bases de Dados        
                =================================================================

                    1  - Implementação de Delegate Personalizado para Descontos
                    2  - Ações Multilíngues com Action<string>
                    3  - Cálculo de Área Utilizando Func
                    4  - Monitoramento de Temperatura com Evento Personalizado
                    5  - Notificação de Conclusão de Download com Eventos
                    6  - Sistema de Registro com Multicast Delegate
                    7  - Garantia de Robustez em Invocação de Delegates
                    11 - Manipulação de Strings com Delegates Encadeados


                 Digite o número do exercício para executar ou 0 para sair: ");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    opcao = -1;
                }

                Console.Clear();

                ExecutarExercicio? exercicio = null;
                switch (opcao)

                {
                    case 1:
                        exercicio = Exercicios.Exercicio1.Executar;
                        break;
                    case 2:
                        exercicio = Exercicios.Exercicio2.Executar;
                        break;
                    case 3:
                        exercicio = Exercicios.Exercicio3.Executar;
                        break;
                    case 4:
                        exercicio = Exercicios.Exercicio4.Executar;
                        break;
                    case 5:
                        exercicio = Exercicios.Exercicio5.Executar;
                        break;
                    case 6:
                        exercicio = Exercicios.Exercicio6.Executar;
                        break;
                    case 7:
                        exercicio = Exercicios.Exercicio7.Executar;
                        break;
                    case 11:
                        exercicio = Exercicios.Exercicio11.Executar;
                        break;
                    case 0:
                        Console.WriteLine("Saindo do programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida, digite novamente.");
                        break;
                }

                exercicio?.Invoke();

                if (opcao != 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Pressione qualquer tecla para retornar ao menu.");
                    Console.ReadKey();
                }
            } while (opcao != 0);
        }
    }
}