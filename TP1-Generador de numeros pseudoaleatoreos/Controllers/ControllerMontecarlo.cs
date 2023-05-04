using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1_Generador_de_numeros_pseudoaleatoreos.Forms;

namespace TP1_Generador_de_numeros_pseudoaleatoreos.Controllers
{
    class ControllerMontecarlo
    {

        Montecarlo Interfaz;
        double CostoAcumCorrectivo;
        double CostoAcumPreventivo;
        double CantidadDiasPreventiva;
        double CantidadDiasCorrectiva;

        public ControllerMontecarlo(Montecarlo interfaz)
        {
            this.Interfaz = interfaz;
        }

        public void IngresarDatos(int n, int desde, int ko, int km)
        {
            MantenimientoCorrectivo gestorCorrectivo = new MantenimientoCorrectivo(this);
            gestorCorrectivo.Simular(n, desde, ko);

            MantenimientoPreventivo gestorPreventivo = new MantenimientoPreventivo(this);
            gestorPreventivo.Simular(n, desde, ko, km);

            GenerarConclusion();
        }

        public void MostrarFilaCorrectiva(double[] filaAMostrar)
        {
            Interfaz.MostrarFilaCorrectiva(filaAMostrar);
        }

        public void MostrarFilaPreventiva(double[] filaAMostrar)
        {
            Interfaz.MostrarFilaPreventiva(filaAMostrar);
        }

        public void SetearCantidadDiasPreventiva(double dias)
        {
            this.CantidadDiasPreventiva = dias;
        }

        public void SetearCantidadDiasCorrectiva(double dias)
        {
            this.CantidadDiasCorrectiva = dias;
        }

        public void SetearAcumuladoCorrectiva(double calculoAcum)
        {
            this.CostoAcumCorrectivo = calculoAcum;
        }

        public void SetearAcumuladoPreventiva(double calculoAcum)
        {
            this.CostoAcumPreventivo = calculoAcum;
        }

        public void GenerarConclusion()
        {
            string mensaje = "El valor del Costo Acumulado del Correctivo es igual a $" + CostoAcumCorrectivo + 
                " en " + CantidadDiasCorrectiva + " dias, mientras que el de la estrategia Preventiva es $" + CostoAcumPreventivo + " en " + 
                CantidadDiasPreventiva + " dias. ";

            double costoDiarioPromedioPreventiva = Math.Round((CostoAcumPreventivo / CantidadDiasPreventiva), 2);
            double costoDiarioPromedioCorrectiva = Math.Round((CostoAcumCorrectivo / CantidadDiasCorrectiva), 2);

            if (costoDiarioPromedioCorrectiva < costoDiarioPromedioPreventiva)
            {
                mensaje += "De esta forma, se decide de que la mejor estrategia es la Correctiva.";
            }
            else
            {
                mensaje += "De esta forma, se decide de que la mejor estrategia es la Preventiva.";
            }

            Interfaz.MostrarMensaje(mensaje);           
            Interfaz.MostrarCostoMensualPromedio(costoDiarioPromedioCorrectiva, costoDiarioPromedioPreventiva);
        }
    }
}
