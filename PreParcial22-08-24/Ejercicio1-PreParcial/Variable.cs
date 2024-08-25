using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_PreParcial
{
    public class Variable : Costo
    {
        public double PrecioPorUnidad { get; private set; }
        public double Unidades { get; private set; }
        override public double ValorFinal
        {
            get
            {
                return PrecioPorUnidad*Unidades;
            }
        }

        public Variable(string concepto, int unidades, double precioPorUnidad):base(concepto)
        {
            Unidades = unidades;
            PrecioPorUnidad = precioPorUnidad;
        }

        override public string VerDetalle()
        {
            return $"Concepto: {base.Concepto}, Unidades: {Unidades}, Precio x Uni: {PrecioPorUnidad}\r\n Total: {ValorFinal:C2}";
        }
    }
}
