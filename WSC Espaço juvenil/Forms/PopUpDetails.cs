using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSC_Espaço_juvenil.Forms
{
    public partial class PopUpDetails : Form
    {
        public PopUpDetails(Image picImage,string tipo,string texto)
        {
            InitializeComponent();
            pictureBox1.Image = picImage;
            label1.Text = texto;
            label2.Text = tipo;
        }
    }
}
