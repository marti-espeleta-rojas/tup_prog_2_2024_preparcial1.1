using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1_PreParcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Costo e = null;
        ArrayList envios = new ArrayList();
        int cont = 0;

        private void btnAltaEnvio_Click(object sender, EventArgs e)
        {
            Envio envio = new Envio();
            Costo costoFijo = new Fijo("Peaje puente zárate", 300);
            envio.AgregarCosto(costoFijo);
            envios.Add(costoFijo);
            Costo costoVariable = new Variable("Combustible - litros", 500, 1500.5);
            envio.AgregarCosto(costoVariable);
            envios.Add(costoVariable);
            cont += 2;
            lbxVerDetalles.Items.Clear();
        }

        private void btnListarEnvios_Click(object sender, EventArgs e)
        {
            for (int n=0; n<cont;n++)
            {
                if (envios[n] is Fijo)
                {
                    this.e = (Fijo)envios[n];
                }
                else
                {
                    this.e = (Variable)envios[n];
                }
                lbxVerDetalles.Items.Add(this.e.VerDetalle());
            }
        }
    }
}
