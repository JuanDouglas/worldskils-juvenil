using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSC_Espaço_juvenil
{
    public partial class Main : Form
    {
        ErrorProvider error = new ErrorProvider();
        public Main()
        {
            InitializeComponent();
            listFormas.DataSource = new string[] {
            "Email Marketing","Amigo","Internet","televisão","Rádio","Outro"
            };
        }
        private void Valida(object sender, EventArgs e) {
            var temp = (TextBox)sender;
            error.Clear();
            switch (temp.Name) {
                case "txtEmail":
                    if (Valido(temp.Text, true) == false)
                        error.SetError((TextBox)sender, "O campo email deve ser preenchido com um email!");
                    break;
                case "txtNome":
                    if (Valido(temp.Text, false) == false)
                        error.SetError((TextBox)sender, "Este deve ser preenchido!");
                    break;
            }
        }
        public bool Valido(string text, bool email)
        {
            if (text.Length < 3) return false;
            if (email) if (text.Contains('@') == false) return false;
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Aqui será implementado o métado que adicona ao banco de dados!
            if (Valido(txtNome.Text, false) && Valido(txtEmail.Text, true))
            {
                this.Visible = false;
                new Forms.GameScreen(txtNome.Text).Show();
            }
        }
    }
}
