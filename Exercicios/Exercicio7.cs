using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1DR4DesWeb.Exercicios
{
    internal class Exercicio7
    {
        public static void Executar()
        {
            var logger = new Logger();
            Action<string> logDelegate = null;

            logDelegate?.Invoke("Teste de log sem métodos registrados.");

            logDelegate += logger.LogToConsole;
            logDelegate += logger.LogToFile;
            logDelegate += logger.LogToDatabase;

            logDelegate?.Invoke("Teste de log com métodos registrados.");
        }
    }
}
