using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp_Info_Boton
{
    public partial class Control_conBoton : UserControl
    {
        private bool pulsado = false;
        public Control_conBoton()
        {
            InitializeComponent();
        }

        private void boton_Click(object sender, EventArgs e)
        {
            if (pulsado)
            {
                boton.BackgroundImage = Comp_Info_Boton.Properties.Resources.info_claro;
                pulsado = false;
            }
            else
            {
                boton.BackgroundImage = Comp_Info_Boton.Properties.Resources.info_oscuro;
                pulsado = true;
            }
        }
    }
}
