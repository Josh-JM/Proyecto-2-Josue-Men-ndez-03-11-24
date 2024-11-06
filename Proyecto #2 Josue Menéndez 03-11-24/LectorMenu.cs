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
    public partial class LectorMenu : UserControl
    {
        public LectorMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 PrincipalForm = (Form1)this.ParentForm;
            PrincipalForm.ShowPrincipalMenu();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 PrincipalForm = (Form1)this.ParentForm;
            PrincipalForm.ShowLectorLoan();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 PrincipalForm = (Form1)this.ParentForm;
            PrincipalForm.ShowLectorDevolution();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 PrincipalForm = (Form1)this.ParentForm;
            PrincipalForm.UndoLastAction();
        }
    }
}
