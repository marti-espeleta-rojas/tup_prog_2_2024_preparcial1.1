using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_PreParcial
{
    internal class Envio
    {
        public double ValorTotal { get; private set; }
        Costo c = null;
        ArrayList costos = new ArrayList();
        int cont = 0;
        public string VerDetalle()
        {
            if (costos[cont] is Fijo)
            {
                c = (Fijo)costos[cont];
            }
            else
            {
                c = (Variable)costos[cont];
            }
            return $"{c.VerDetalle()}";
        }

        public void AgregarCosto(Costo nuevo)
        {
            costos.Add(nuevo);
        }
    }
}
