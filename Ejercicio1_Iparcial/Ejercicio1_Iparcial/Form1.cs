using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1_Iparcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ejecutarbutton1_Click(object sender, EventArgs e)
        {
            int numero;
            numero = int.Parse(ingresarnumtextBox1.Text);

            if ( numero % 2 ==0 & numero >= 0)
            {
                elnumeroestextBox2.Text = "numero par y positivo";
            }
            else if (numero % 2 == 0 & numero <= 0)
            {
                elnumeroestextBox2.Text = "numero par y negativo";
            }
            else if (numero % 2 != 0 & numero >= 0)
            {
                elnumeroestextBox2.Text = "numero impar y positivo";
            }
            else
            {
                elnumeroestextBox2.Text = " numero impar y negativo";
            }



        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            elnumeroestextBox2.Clear();
            ingresarnumtextBox1.Clear();
        }
    }
}
