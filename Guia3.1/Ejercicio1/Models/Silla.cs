using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Silla:Producto
    {
        public Silla(string descripcion,double precioBase,int tipoMaterial):base(descripcion,precioBase,tipoMaterial)
        {
            base.precioBase = precioBase;
            base.TipoMaterial = tipoMaterial;

        }

        public override double CalcularPrecio()
        {
            double precioSilla = 0;

            if (TipoMaterial == 0)
            {
                precioSilla = (precioBase * (1 + TipoMaterial * 0.25));
            }
            else if (TipoMaterial == 1)
            {
                precioSilla = (precioBase * (1 + TipoMaterial * 0.25));
            }
            else
            {
                precioSilla = (precioBase * (1 + TipoMaterial * 0.25));
            }
            return precioSilla;
        }

        public override string VerDetalle()
        {
            return ("La silla es de:"+TipoMaterial+("Tiene el precio base de: ")+precioBase);
        }

    }
}
