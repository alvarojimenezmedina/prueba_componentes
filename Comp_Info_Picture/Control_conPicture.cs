using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp_Info_Picture
{
    public partial class Control_conPicture : UserControl
    {
        private bool pulsado = false;

        public Control_conPicture()
        {
            InitializeComponent();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (pulsado)
            {
                pictureBox.Image = Comp_Info_Picture.Properties.Resources.info_claro;
                pulsado = false;
            }
            else
            {
                pictureBox.Image = Comp_Info_Picture.Properties.Resources.info_oscuro;
                pulsado = true;
            }
        }
    }
}
