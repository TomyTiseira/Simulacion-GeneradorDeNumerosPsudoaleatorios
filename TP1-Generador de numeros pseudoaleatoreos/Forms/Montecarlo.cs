using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1_Generador_de_numeros_pseudoaleatoreos.Controllers;

namespace TP1_Generador_de_numeros_pseudoaleatoreos.Forms
{
    public partial class Montecarlo : Form
    {
        ControllerMontecarlo controller;
        public Montecarlo()
        {
            InitializeComponent();
        }

        private void CalcularMontecarlo(object sender, EventArgs e)
        {
            controller = new ControllerMontecarlo(this);
            dvgCorrectiva.Rows.Clear();
            dvgPreventiva.Rows.Clear();

            if(ValidarDatos())
            {
                controller.IngresarDatos(int.Parse(txtN.Text), int.Parse(txtDesde.Text), int.Parse(txtReparacion.Text), int.Parse(txtMantenimiento.Text));
            }
        }

        private bool ValidarDatos()
        {
            if (txtN.Text == "" || txtDesde.Text == "" ||
               txtMantenimiento.Text == "" || txtReparacion.Text == "")
            {
                MessageBox.Show("Ingrese todos los valores", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (int.Parse(txtN.Text) <= 0 || int.Parse(txtDesde.Text) <= 0 ||
                int.Parse(txtMantenimiento.Text) <= 0 || int.Parse(txtReparacion.Text) <= 0)
            {
                MessageBox.Show("Debe ingresar valores positivos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (int.Parse(txtN.Text) < 500)
            {
                MessageBox.Show("Debe ingresar valores iguales o mayores a 500", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if ((int.Parse(txtN.Text) - 499) < int.Parse(txtDesde.Text))
            {
                MessageBox.Show("Ingrese un valor valido para Desde", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDesde.Text = ""; txtDesde.Focus();
                return false;
            }

            return true;
        }

        public void MostrarFilaCorrectiva(double[] filaAMostrar)
        {
            dvgCorrectiva.Rows.Add(filaAMostrar[0], filaAMostrar[1], filaAMostrar[2], filaAMostrar[3], filaAMostrar[4],
               "$" + filaAMostrar[5], "$" + filaAMostrar[6].ToString(), filaAMostrar[7].ToString());
        }

        public void MostrarFilaPreventiva(double[] filaAMostrar)
        {
            dvgPreventiva.Rows.Add(filaAMostrar[0], filaAMostrar[1], filaAMostrar[2], filaAMostrar[3], filaAMostrar[4],
                filaAMostrar[5], "$" + filaAMostrar[6].ToString(), "$" + filaAMostrar[7].ToString(), "$" + filaAMostrar[8].ToString(), "$" + filaAMostrar[9].ToString(), filaAMostrar[10].ToString(), filaAMostrar[11].ToString());
        }

        public void MostrarMensaje(string mensaje)
        {
            lblEstrategia.Text = mensaje;
        }

        public void MostrarCostoMensualPromedio(double costoCorrectiva, double costoPreventiva)
        {
            this.lblCostoPromedioCorrectiva.Text = "Costo diario promedio de la estrategia Correctiva: $" + costoCorrectiva.ToString() + ".";
            this.lblCostoPromedioPreventiva.Text = "Costo diario promedio de la estrategia Preventiva: $" + costoPreventiva.ToString() + ".";
        }
    }
}
