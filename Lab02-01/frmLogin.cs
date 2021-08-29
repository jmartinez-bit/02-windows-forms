using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_01
{
    public partial class frmLogin : Form
    {

        public List<Usuario> usuarios { get; set; }
        public frmLogin()
        {
            usuarios = new List<Usuario>();
            Usuario usuario1 = new Usuario("lincoln", "12345");
            Usuario usuario2 = new Usuario("martinez", "12345");
            usuarios.Add(usuario1);
            usuarios.Add(usuario2);
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            for ( int i = 0; i < usuarios.Count; i++ )
            {

                if(usuarios[i].username.Equals(txtUsuario.Text) &&
                    usuarios[i].password.Equals(txtPassword.Text) )
                {
                    PrincipalMDI principal = new PrincipalMDI();
                    principal.Show();
                    this.Hide();
                    break;
                }
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
