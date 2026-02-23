using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1DR4DesWeb.Exercicios
{
    public class DownloadManager
    {
        public event Action DonwloadCompleted;
        public void StartDownload()
        {
            Console.WriteLine("O download foi iniciado.");
            Thread.Sleep(3000);
            DonwloadCompleted?.Invoke();
        }
    }
}
