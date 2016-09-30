using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldWindowsFormsVB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = this.texto.Text;
            /* muestranombre.Text = "Hola"+nombre+" son las "+DateTime.Now.Hour+
                 ":"+DateTime.Now.Minute;*/
            ToPaTi.Text = "Todo para ti " + nombre;

            foto.Visible = true;

        }

        private void hombre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mujer_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
