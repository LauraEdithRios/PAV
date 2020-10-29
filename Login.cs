using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAV
{
    public partial class Login : Form
    {
        public string usuarioMostrar;
        public string perfilMostrar;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Se debe ingresar un Usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtContraseña.Text == "")
            {
                MessageBox.Show("Se debe ingresar una Contraseña.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (ValidarCredenciales(txtUsuario.Text, txtContraseña.Text))
            {
                MessageBox.Show("Usted ha ingresado al sistema.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuarioMostrar = txtUsuario.Text;
                perfilMostrar = retornarPerfil(txtUsuario.Text);
                this.Close();
            } else
            {
                txtUsuario.Text = "";
                txtContraseña.Text = "";
                MessageBox.Show("Debe ingresar Usuario y/o contraseña validos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public bool ValidarCredenciales(string pUsuario, string pContraseña)
            {
                bool usuarioValido = false;
            
                try
                {                    
                    string consultaSql = string.Concat("SELECT *",
                                                       "    FROM Usuarios",
                                                       "    WHERE usuario = '", pUsuario,"'");
                    DataTable resultado = DataManager.GetInstance().ConsultaSQL(consultaSql);
                               
                if (resultado.Rows.Count >= 1)
                    {
                        if (resultado.Rows[0]["password"].ToString() == pContraseña)
                        {
                            usuarioValido = true;
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(string.Concat("Error de base de datos: ", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }             
                return usuarioValido;
        }

        public string retornarPerfil(string pUsuario)
        {
            string perfilDevuelto = "";
            try
            {
                string consultaSql = string.Concat("SELECT nombre",
                                                   "    FROM Perfiles INNER JOIN Usuarios on Perfiles.id_perfil = Usuarios.id_perfil",
                                                   "    WHERE Usuarios.usuario = '", pUsuario, "'");
                DataTable resultado2 = DataManager.GetInstance().ConsultaSQL(consultaSql);

                if (resultado2.Rows.Count >= 1)
                {
                    perfilDevuelto = resultado2.Rows[0]["nombre"].ToString();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(string.Concat("Error de base de datos: ", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return perfilDevuelto;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
