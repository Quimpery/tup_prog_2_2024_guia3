using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Mesa:Producto
    {
        private double largo;

        public Mesa(string descripcion, double precioBase, int tipoMaterial, double largo) : base(descripcion, precioBase, tipoMaterial)
        {
            
            base.TipoMaterial = tipoMaterial;
            base.precioBase = precioBase;
            this.largo = largo;
        }

        public override double CalcularPrecio()
        {
            double precioMesa = 0;

            if(base.TipoMaterial == 0)
            {
                precioMesa = (precioBase * largo)*(1+base.TipoMaterial*0.33);
            }
            else if(TipoMaterial == 1)
            {
                precioMesa = (precioBase * largo) * (1 + base.TipoMaterial*0.33);
            }
            else
            {
                precioMesa=(precioBase * largo)*(1 + base.TipoMaterial *0.33);
            }
            return precioMesa;            
        }

        public override string VerDetalle()
        {
            return ("La mesa es de: " + base.Descripcion + ("Largo: " + largo + ("Su precio base es de: ") + precioBase));
        }
    }
}
