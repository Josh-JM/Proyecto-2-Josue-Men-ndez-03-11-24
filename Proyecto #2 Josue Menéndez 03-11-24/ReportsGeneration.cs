﻿using System;
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
    public partial class ReportsGeneration : UserControl
    {
        public ReportsGeneration()
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

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 PrincipalForm = (Form1)this.ParentForm;
            Loan Report = PrincipalForm.ShowReport();


            richTextBox1.Text = "Préstamos Activos" + "\n" + $"\nFecha de Préstamo: {Report.LoanDate} \nUsuario del Préstamo: {Report.Lector.Username}\nLibro Prestado: {Report.Book.Title}" + "\n-------------------------------------------------------------";



        }
    }
}
