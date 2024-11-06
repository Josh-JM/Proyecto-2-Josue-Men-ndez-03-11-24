using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto__2_Josue_Menéndez_03_11_24
{
    public partial class LectorLoan : UserControl
    {
        public LectorLoan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 PrincipalForm = (Form1)this.ParentForm;
            PrincipalForm.ShowLectorMenu();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 PrincipalForm = (Form1)this.ParentForm;
            Book SearchedBook = PrincipalForm.SequentialBookSearch(PrincipalForm.BookList, richTextBox2.Text);
            User UserSearch = PrincipalForm.UserFinding(richTextBox1.Text);

            if (SearchedBook.Availability == true)
            {
                SearchedBook.Availability = false;
                PrincipalForm.LoanAdd(SearchedBook, UserSearch);
            }
            else if (SearchedBook.Availability == false)
            {
                PrincipalForm.UsersQueue(UserSearch, richTextBox2.Text);
            }
            richTextBox1.Clear();
            richTextBox2.Clear();
        }


    }
}
