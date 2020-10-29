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

        private void MenuOpsGestionCateg_Click(object sender, EventArgs e)
        {
            GestionDeCategorias gestionDeCategorias = new GestionDeCategorias();
            gestionDeCategorias.ShowDialog();
        }

        private void MenuOpsGestionCurs_Click(object sender, EventArgs e)
        {
            GestionDeCursos gestionDeCursos = new GestionDeCursos();
            gestionDeCursos.ShowDialog();
        }

        private void MenuOpcGestionObjet_Click(object sender, EventArgs e)
        {
            GestionDeObjetivos gestionDeObjetivos = new GestionDeObjetivos();
            gestionDeObjetivos.ShowDialog();
        }

        private void MenuOpsSalir_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
