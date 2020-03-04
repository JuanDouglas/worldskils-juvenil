using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WorldSkills_Espaço_Juvenil.Forms
{
    public partial class Game : Form
    {
        public Game(string  nome)
        {
            InitializeComponent();
            lblNome.Text = nome;
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
