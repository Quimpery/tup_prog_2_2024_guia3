using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal abstract class Producto
    {
        private string descripcion;
        protected double precioBase;
        protected int TipoMaterial;
        public string Descripcion { get { return descripcion; }  }


        public Producto(string descripcion, double precioBase, int tipoMaterial)
        {
            this.descripcion = descripcion;
            this.precioBase = precioBase;
            TipoMaterial = tipoMaterial;
        }

        public abstract double CalcularPrecio();

        public abstract string VerDetalle();
    }
}
