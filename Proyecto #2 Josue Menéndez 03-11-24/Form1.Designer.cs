namespace Proyecto__2_Josue_Menéndez_03_11_24
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            PrincipalPanel = new Panel();
            button2 = new Button();
            button3 = new Button();
            button1 = new Button();
            ContentPanel = new Panel();
            PrincipalPanel.SuspendLayout();
            SuspendLayout();
            // 
            // PrincipalPanel
            // 
            PrincipalPanel.BackgroundImage = (Image)resources.GetObject("PrincipalPanel.BackgroundImage");
            PrincipalPanel.BackgroundImageLayout = ImageLayout.Stretch;
            PrincipalPanel.Controls.Add(button2);
            PrincipalPanel.Controls.Add(button3);
            PrincipalPanel.Controls.Add(button1);
            PrincipalPanel.Location = new Point(0, 0);
            PrincipalPanel.Name = "PrincipalPanel";
            PrincipalPanel.Size = new Size(1920, 1080);
            PrincipalPanel.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = Properties.Resources.Captura_de_pantalla_2024_10_29_002935;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Harlow Solid Italic", 38F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(1278, 781);
            button2.Name = "button2";
            button2.Size = new Size(437, 91);
            button2.TabIndex = 9;
            button2.Text = "Bibliotecario";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = Properties.Resources.Captura_de_pantalla_2024_10_29_002935;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Harlow Solid Italic", 20F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(1395, 971);
            button3.Name = "button3";
            button3.Size = new Size(209, 46);
            button3.TabIndex = 8;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.Captura_de_pantalla_2024_10_29_002935;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Harlow Solid Italic", 38F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(1278, 557);
            button1.Name = "button1";
            button1.Size = new Size(437, 89);
            button1.TabIndex = 7;
            button1.Text = "Lector";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // ContentPanel
            // 
            ContentPanel.Location = new Point(0, 0);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(1920, 1080);
            ContentPanel.TabIndex = 10;
            // 
            // Form1
            // 
            AccessibleRole = AccessibleRole.TitleBar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1920, 1080);
            Controls.Add(PrincipalPanel);
            Controls.Add(ContentPanel);
            DoubleBuffered = true;
            ForeColor = Color.FromArgb(255, 238, 224);
            FormBorderStyle = FormBorderStyle.None;
            MinimizeBox = false;
            Name = "Form1";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "nn";
            Load += Form1_Load;
            Click += Form1_Load;
            PrincipalPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        public Panel PrincipalPanel;
        private Panel ContentPanel;
        private Button button2;
        private Button button3;
        private Button button1;
    }
}
