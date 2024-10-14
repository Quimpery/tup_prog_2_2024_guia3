using Ejercicio1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Mesa prueba;
        Silla prueba2;
        private void btnPrueba_Click(object sender, EventArgs e)
        {
            string dato = ("Algarrobo");
            int material = 1;
            double precio=10.1;
            double largo = 1.0;
            prueba = new Mesa(dato,precio,material,largo);
            prueba2 = new Silla("algarrobo", 12,1);

            prueba.CalcularPrecio();
            prueba2.CalcularPrecio();

            lbResultados.Items.Clear();
            lbResultados.Items.Add(prueba.VerDetalle());
            lbResultados.Items.Add(prueba2.VerDetalle());
            



        }
    }
}
