using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_de_componentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "CAMBIADO";
        }

        private void control_conBoton1_Click(object sender, EventArgs e)
        {
            label1.Text = "CAMBIADO";
        }

        private void control_conPicture1_Click(object sender, EventArgs e)
        {
            label2.Text = "CAMBIADO";
        }
    }
}
