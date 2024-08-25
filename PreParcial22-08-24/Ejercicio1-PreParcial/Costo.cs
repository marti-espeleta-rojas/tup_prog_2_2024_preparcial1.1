using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_PreParcial
{
    public abstract class Costo
    {
        public string Concepto { get; private set; }
        virtual public double ValorFinal { get; protected set; }

        public Costo(string concepto)
        {
            Concepto = concepto;
        }

        public abstract string VerDetalle();
    }
}
