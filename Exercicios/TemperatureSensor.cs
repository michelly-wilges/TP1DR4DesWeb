using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1DR4DesWeb.Exercicios
{
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
