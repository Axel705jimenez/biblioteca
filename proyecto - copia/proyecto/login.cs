using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        public string usuario;
        string contra;
        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btnINico_Click(object sender, EventArgs e)
        {
            
            administrador ad = new administrador();
            
            contra = txtContra.Text;
            usuario = txtUsuario.Text;
            if (usuario == "admin" || contra == "biblioteca")
            {
                ad.Show();
                this.Close();
            }
        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {
            txtContra.UseSystemPasswordChar = true;
        }
    }
}
