using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestauranteUnicode.Views.Cadastrar;

namespace RestauranteUnicode.Views
{
    public partial class MainForm : Form
    {
        public static Panel MainPanel;
        public MainForm()
        {
            InitializeComponent();
            MainPanel = panel1;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var cad = new Cadastrar.Cadastrar();
            cad.TopLevel = false;
            cad.FormBorderStyle = FormBorderStyle.None;
            cad.Dock = DockStyle.Fill;
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(cad);
            this.panel1.Tag = cad;
            cad.BringToFront();
            cad.Show();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel1.Visible = true;
            this.panel1.Enabled = true;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.TopLevel = false;
            dashboard.FormBorderStyle = FormBorderStyle.None;
            dashboard.Dock = DockStyle.Fill;
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(dashboard);
            this.panel1.Tag = dashboard;
            dashboard.BringToFront();
            dashboard.Show();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel1.Visible = true;
            this.panel1.Enabled = true;
        }
    }
}
