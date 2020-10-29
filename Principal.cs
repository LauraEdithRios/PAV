using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PAV
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Login login = new Login();
            login.ShowDialog();
            toolStripStatusLabel1.Text = "Usuario: " + login.usuarioMostrar.ToUpper() + " | Perfil: " + login.perfilMostrar;
        }

        
    }
}
