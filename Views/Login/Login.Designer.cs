using RestauranteUnicode.Models.CustomControls;

namespace RestauranteUnicode
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            panel3 = new Panel();
            button1 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            buttonCustom2 = new ButtonCustom();
            buttonCustom1 = new ButtonCustom();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            checkBox1 = new CheckBox();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Tomato;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 44);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 192, 128);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(346, 37);
            label1.TabIndex = 0;
            label1.Text = "UNICODE Restaurante";
            // 
            // panel3
            // 
            panel3.Location = new Point(355, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(390, 41);
            panel3.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Dock = DockStyle.Right;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(3, 50);
            button1.Name = "button1";
            button1.Size = new Size(56, 0);
            button1.TabIndex = 10;
            button1.Text = "teste";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tomato;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 456);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Info;
            panel2.Controls.Add(buttonCustom2);
            panel2.Controls.Add(buttonCustom1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(checkBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(200, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 456);
            panel2.TabIndex = 2;
            // 
            // buttonCustom2
            // 
            buttonCustom2.BackColor = Color.Tomato;
            buttonCustom2.FlatAppearance.BorderSize = 0;
            buttonCustom2.FlatStyle = FlatStyle.Flat;
            buttonCustom2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCustom2.ForeColor = Color.White;
            buttonCustom2.Location = new Point(172, 349);
            buttonCustom2.Name = "buttonCustom2";
            buttonCustom2.Size = new Size(250, 40);
            buttonCustom2.TabIndex = 20;
            buttonCustom2.Text = "Cadastre-se";
            buttonCustom2.UseVisualStyleBackColor = false;
            buttonCustom2.Click += buttonCustom2_Click;
            // 
            // buttonCustom1
            // 
            buttonCustom1.BackColor = Color.Tomato;
            buttonCustom1.FlatAppearance.BorderSize = 0;
            buttonCustom1.FlatStyle = FlatStyle.Flat;
            buttonCustom1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCustom1.ForeColor = Color.White;
            buttonCustom1.Location = new Point(172, 281);
            buttonCustom1.Name = "buttonCustom1";
            buttonCustom1.Size = new Size(250, 40);
            buttonCustom1.TabIndex = 0;
            buttonCustom1.Text = "Entrar";
            buttonCustom1.UseVisualStyleBackColor = false;
            buttonCustom1.Click += buttonCustom1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(172, 231);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 23);
            textBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(172, 135);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 23);
            textBox1.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(234, 18);
            label4.Name = "label4";
            label4.Size = new Size(101, 39);
            label4.TabIndex = 10;
            label4.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(172, 188);
            label3.Name = "label3";
            label3.Size = new Size(82, 29);
            label3.TabIndex = 9;
            label3.Text = "Senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(172, 89);
            label2.Name = "label2";
            label2.Size = new Size(82, 29);
            label2.TabIndex = 8;
            label2.Text = "E-mail";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(276, 425);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(124, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Esqueceu a senha?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(800, 500);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(800, 500);
            MinimumSize = new Size(800, 500);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UnicodeFormStart";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private CheckBox checkBox1;
        private Label label2;
        private Label label3;
        private Panel panel3;
        private Button button1;
        private Label label4;         
        private TextBox textBox2;
        private TextBox textBox1;
        private ButtonCustom buttonCustom2;
        private ButtonCustom buttonCustom1;
    }
}
