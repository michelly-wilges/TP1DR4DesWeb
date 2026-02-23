using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1DR4DesWeb.Exercicios
{
    internal class Exercicio5
    {
        public static void Executar()
        {
            var gerenciador = new DownloadManager();
            gerenciador.DonwloadCompleted += OnDownloadCompleted;
            gerenciador.StartDownload();
        }
        static void OnDownloadCompleted()
        {
                     Console.WriteLine("O download foi concluído!");
        }
    }
}
