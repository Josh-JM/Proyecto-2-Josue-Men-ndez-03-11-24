using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto__2_Josue_Menéndez_03_11_24
{
    public partial class LibrarianLogin : UserControl
    {
        public LibrarianLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 PrincipalForm = (Form1)this.ParentForm;
            PrincipalForm.ShowPrincipalMenu();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 PrincipalForm = (Form1)this.ParentForm;

            if (PrincipalForm.FindUsersLibrarians(richTextBox1.Text) == true && PrincipalForm.FindPasswordsLibrarians(textBox1.Text) == true)
            {
                PrincipalForm.ShowLibrarianMenu();
            }
            else
            {
                MessageBox.Show("Usuario no Encontrado o Credenciales Incorrectas");
            }


        }


    }
}
