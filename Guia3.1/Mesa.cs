using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia3._1
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

        public override double CalcularPrecio(double precioBase,double largo,int tipoMaterial)
        {
            double precioMesa = 0;

            if(tipoMaterial == 0)
            {
                precioMesa = (precioBase * largo)*(1+tipoMaterial);
            }
            else if(tipoMaterial == 1)
            {
                precioMesa = (precioBase * largo) * (1 + tipoMaterial);
            }
            else
            {
                precioMesa=(precioBase * largo)*(1 + tipoMaterial);
            }
            return precioMesa;            
        }
        public override string VerDetalle()
        {
            return
        }
    }
}
