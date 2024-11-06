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
    public partial class LectorDevolution : UserControl
    {
        public LectorDevolution()
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
            LectorWaiting QueueTitleSearch = PrincipalForm.QueueSearch(richTextBox1.Text);

            if (QueueTitleSearch != null)
            {

                PrincipalForm.Devolution(SearchedBook, UserSearch);
                PrincipalForm.DeleteQueueUserWaiting(PrincipalForm.LectorsWaiting, QueueTitleSearch);
                PrincipalForm.LoanAdd(SearchedBook, QueueTitleSearch.Lector);

            }
            else if (QueueTitleSearch == null)
            {
                SearchedBook.Availability = true;
                PrincipalForm.Devolution(SearchedBook, UserSearch);
            }
            richTextBox1.Clear();
        }


    }
}
