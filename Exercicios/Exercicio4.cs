using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1DR4DesWeb.Exercicios
{
    internal class Exercicio4
    {
        public static void Executar()
        {
            var sensor = new TemperatureSensor();
            sensor.TemperatureExceeded += TemperaturaExcedida;
            Console.WriteLine("Entre com a leitura da temperatura (em ºC) ou digite 'sair' para encerrar.");
            string entrada;
            do
            {
                Console.Write("Temperatura: ");
                entrada = Console.ReadLine();

                if (entrada?.ToLower() == "sair")
                { }

                else if (double.TryParse(entrada, out double temperatura))
                {
                    sensor.LerTemperatura(temperatura);
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Digite um número ou 'sair'.");
                }
            } while (entrada?.ToLower() != "sair");
            Console.WriteLine("Encerrando programa...");

            static void TemperaturaExcedida(double temperatura)
            {
                Console.WriteLine($"Atenção! Temperatura além do limite permitido: ({temperatura} ºC).");
            }
        }

        public class TemperatureSensor
        {
            public event Action<double> TemperatureExceeded;

            public void LerTemperatura(double value)
            {
                if (value > 100)
                {
                    TemperatureExceeded?.Invoke(value);
                }
            }
        }
    }
}
