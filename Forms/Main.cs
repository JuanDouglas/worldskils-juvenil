using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace WorldSkills_Espaço_Juvenil
{
    public partial class Main : Form
    {
        ErrorProvider provider = new ErrorProvider();
        public Main()
        {
            InitializeComponent();
            ListConheceu.DataSource = new string[] { "Email Marketing","Amigo","Internet","Televisão","Rádio","Outros"};
        }
        private void Valida(object sender, EventArgs e) {
            provider.Clear();
            var @obj = (TextBox)sender;
            if (IsValid(obj.Text) == false) provider.SetError((TextBox)sender, "Por favor digite um nome valido!");
        }
        private void ValidaEmail(object sender, EventArgs e)
        {
            var @obj = (TextBox)sender;
            if (IsValidEmail(obj.Text) == false) provider.SetError((TextBox)sender, "Por favor digite um email valido!");
        }
        private bool IsValid(string text)
        {
            if (text.Length < 2)
                return false;
            provider.Clear();
            return true;
        }
        private bool IsValidEmail(string text)
        {
            provider.Dispose();
            if (text.Length < 2)
                return false;
            if (text.Contains('@') == false)  return false;
            provider.Clear();
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IsValid(txtNome.Text) && IsValidEmail(txtEmail.Text)) {
                new Forms.Game(txtNome.Text).Show();
                this.Visible=false;
            }

        }
    }
}
