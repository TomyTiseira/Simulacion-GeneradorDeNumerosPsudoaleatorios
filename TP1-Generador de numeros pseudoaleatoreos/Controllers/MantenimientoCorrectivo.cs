using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Generador_de_numeros_pseudoaleatoreos.Controllers
{
    class MantenimientoCorrectivo
    {
        ControllerMontecarlo controller;

        public MantenimientoCorrectivo(ControllerMontecarlo controller)
        {
            this.controller = controller;
        }

        public void Simular(int n, int desde, int ko)
        {
            Random random = new Random();
            double rnd = Math.Round(random.NextDouble(), 2);
            int costoAcumulado = 0;
            double cantAveria = 0;
            double dia = 1;
            double enCuantoAveria = ObtenerDiaAveria(rnd);
            double diaDeAveria = dia + enCuantoAveria;

            if (rnd == 1)
            {
                rnd = 0.99;
            }

            double[] actual = new double[8] { 0, dia, rnd, enCuantoAveria, diaDeAveria, 0, costoAcumulado, cantAveria };

            double filasMostradas = 0;

            if (desde == 1)
            {
                controller.MostrarFilaCorrectiva(actual);
                filasMostradas++;
            }

            for (int ciclo = 1; ciclo <= n; ciclo++)
            {
                dia = actual[4];
                rnd = Math.Round(random.NextDouble(), 2);
                enCuantoAveria = ObtenerDiaAveria(rnd);
                diaDeAveria = dia + enCuantoAveria;
                costoAcumulado += ko;
                cantAveria++;
                double costoTotal = ko;

                if(rnd == 1)
                {
                    rnd = 0.99;
                }

                actual = new double[] { ciclo, dia, rnd, enCuantoAveria, diaDeAveria, costoTotal, costoAcumulado, cantAveria };

                if (ciclo >= desde && filasMostradas <= 500)
                {
                    controller.MostrarFilaCorrectiva(actual);
                    filasMostradas++;
                }
            }

            controller.MostrarFilaCorrectiva(actual);
            controller.SetearAcumuladoCorrectiva(costoAcumulado);
            controller.SetearCantidadDiasCorrectiva(dia);
        }

        private double ObtenerDiaAveria(double rnd)
        {
            if(rnd < 0.25)
            {
                return 5;
            }
            if(rnd < 0.70)
            {
                return 6;
            }
            if(rnd < 0.90)
            {
                return 7;
            }
            return 8;
        }
    }
}
