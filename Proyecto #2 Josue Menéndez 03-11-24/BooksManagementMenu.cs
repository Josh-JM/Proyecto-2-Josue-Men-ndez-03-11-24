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
    public partial class BooksManagementMenu : UserControl
    {
        public BooksManagementMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 PrincipalForm = (Form1)this.ParentForm;
            PrincipalForm.ShowLibrarianMenu();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 PrincipalForm = (Form1)this.ParentForm;
            Book Search = PrincipalForm.SequentialBookSearchWithISB(PrincipalForm.BookList, maskedTextBox1.Text);
            if (Search == null)
            {
                bool Availability = true;
                if (comboBox1.Text == "Disponible")
                {
                    Availability = true;
                }
                else
                {
                    Availability = false;
                }
                PrincipalForm.AddBook(richTextBox1.Text, richTextBox2.Text, maskedTextBox1.Text, richTextBox4.Text, Availability);
                MessageBox.Show("Libro Agregado Correctamente:");
            }
            else
            {
                MessageBox.Show("No es Posible Agregar un Libro con un ISBN ya Existente...");
            }
            richTextBox1.Clear();
            richTextBox2.Clear();
            maskedTextBox1.Clear();
            richTextBox4.Clear();
            comboBox1.Text = null;
        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 PrincipalForm = (Form1)this.ParentForm;
            Book SearchedBook = PrincipalForm.SequentialBookSearch(PrincipalForm.BookList, richTextBox6.Text);
            if (SearchedBook != null)
            {
                richTextBox5.Text = ("          --- Libro ---" + "\n" + $"\nTitulo: {SearchedBook.Title}" + $"\nAutor: {SearchedBook.Author}" + $"\nISBN: {SearchedBook.ISBN}" + $"\nGénero: {SearchedBook.Genre}" + $"\nDisponibilidad: {SearchedBook.Availability}");
            }
            else
            {
                MessageBox.Show("Libro no Encontrado...");
            }

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void BooksManagementMenu_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 PrincipalForm = (Form1)this.ParentForm;
            Book SearchedBookDelete = PrincipalForm.BookRemove(PrincipalForm.BookList, richTextBox7.Text);
            if (SearchedBookDelete != null)
            {
                PrincipalForm.BookList.Remove(SearchedBookDelete);
                richTextBox7.Clear();
                MessageBox.Show("Libro Eliminado Correctamente...");
            }
            else
            {
                MessageBox.Show("Libro no Encontrado...");
            }
        }


    }
}
