using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1DR4DesWeb.Exercicios
{
    internal class Exercicio6
    {
        public static void Executar()
        {
            var logger = new Logger();
            Action<string> logDelegate = null;

            logDelegate += logger.LogToConsole;
            logDelegate += logger.LogToFile;
            logDelegate += logger.LogToDatabase;

            logDelegate("Programa iniciado.");
        }
    }
}
