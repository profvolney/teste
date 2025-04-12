namespace RestauranteUnicode.Views
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            panel3 = new Panel();
            btnDashboard = new Button();
            panel4 = new Panel();
            btnCardapio = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 450);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Tomato;
            panel3.Controls.Add(btnDashboard);
            panel3.Location = new Point(0, 133);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 44);
            panel3.TabIndex = 1;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Tomato;
            btnDashboard.FlatAppearance.BorderColor = Color.Tomato;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Constantia", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.Snow;
            btnDashboard.Location = new Point(3, 3);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(194, 38);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Tomato;
            panel4.Controls.Add(btnCardapio);
            panel4.Location = new Point(0, 83);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 44);
            panel4.TabIndex = 0;
            // 
            // btnCardapio
            // 
            btnCardapio.BackColor = Color.Tomato;
            btnCardapio.FlatAppearance.BorderColor = Color.Tomato;
            btnCardapio.FlatAppearance.BorderSize = 0;
            btnCardapio.FlatStyle = FlatStyle.Flat;
            btnCardapio.Font = new Font("Constantia", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCardapio.ForeColor = Color.Snow;
            btnCardapio.Location = new Point(3, 3);
            btnCardapio.Name = "btnCardapio";
            btnCardapio.Size = new Size(194, 38);
            btnCardapio.TabIndex = 0;
            btnCardapio.Text = "Cardápio";
            btnCardapio.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 450);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Tomato;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Button btnCardapio;
        private Panel panel2;
        private Panel panel3;
        private Button btnDashboard;
        private PictureBox pictureBox1;
    }
}