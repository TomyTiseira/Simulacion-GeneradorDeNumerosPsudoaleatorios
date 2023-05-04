using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Generador_de_numeros_pseudoaleatoreos.Controllers
{
    class MantenimientoPreventivo
    {

        ControllerMontecarlo controller;

        public MantenimientoPreventivo(ControllerMontecarlo controller)
        {
            this.controller = controller;
        }

        public void Simular(int n, int desde, int ko, int km)
        {
            Random random = new Random();
            double rnd = Math.Round(random.NextDouble(), 2);
            double dia = 1;
            double diaReparacion = 6;
            double enCuantoAveria = ObtenerDiaAveria(rnd);
            double diaDeAveria = dia + enCuantoAveria;
            double costoAcumulado = 0;
            double cantidadAverias = 0;
            double cantidadRevisiones = 0;

            if (rnd == 1)
            {
                rnd = 0.99;
            }

            double[] actual = new double[12] { 0, dia, diaReparacion, rnd, enCuantoAveria, diaDeAveria, 0, 0, 0, costoAcumulado, cantidadAverias, cantidadRevisiones };

            double filasMostradas = 0;

            if (desde == 1)
            {
                controller.MostrarFilaPreventiva(actual);
                filasMostradas++;
            }

            for (int ciclo = 1; ciclo <= n; ciclo++)
            {
                double costoTotal = 0;
                double costoReparacion = 0;
                double costoMantenimiento = 0;

                if (actual[2] < actual[5])
                {
                    dia = actual[2];
                    costoMantenimiento = km;
                    costoTotal = km;
                    cantidadRevisiones++;
                    diaReparacion = actual[2] + 6;
                }

                if (actual[5] <= actual[2])
                {
                    dia = actual[5];
                    costoReparacion = ko;
                    costoTotal = ko;
                    cantidadAverias++;
                }

                if(actual[2] == actual[5])
                {
                    diaReparacion = actual[2] + 6;
                }

                costoAcumulado += costoTotal;
                rnd = Math.Round(random.NextDouble(), 2);
                enCuantoAveria = ObtenerDiaAveria(rnd);
                diaDeAveria = dia + enCuantoAveria;

                if (rnd == 1)
                {
                    rnd = 0.99;
                }

                actual = new double[] {ciclo, dia, diaReparacion, rnd, enCuantoAveria, diaDeAveria, costoReparacion, costoMantenimiento, costoTotal, costoAcumulado, cantidadAverias, cantidadRevisiones };
                
                if (ciclo >= desde && filasMostradas <= 500)
                {
                    controller.MostrarFilaPreventiva(actual);
                    filasMostradas++;
                }
            }

            controller.MostrarFilaPreventiva(actual);
            controller.SetearAcumuladoPreventiva(costoAcumulado);
            controller.SetearCantidadDiasPreventiva(dia);
        }

        public double ObtenerDiaAveria(double rnd)
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
