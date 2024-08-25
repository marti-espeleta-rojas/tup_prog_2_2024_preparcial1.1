using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_PreParcial
{
    public class Fijo : Costo
    {
        public Fijo(string concepto, double valorFinal):base(concepto)
        {
            ValorFinal = valorFinal;
        }
        override public string VerDetalle()
        {
            string detalle = $"Concepto: {base.Concepto}, Total: {ValorFinal}";
            return detalle;
        }

    }
}
