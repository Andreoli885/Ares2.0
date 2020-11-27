using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ares2._0
{
    public partial class logeo : Form
    {
        public logeo()
        {
            InitializeComponent();
        }

        private void Iniciar_Click(object sender, EventArgs e)
        {
            
            var usuario = Usuario.Text;
            var password = contraseña.Text;

            usuariodao.uwu();

            if(usuariodao.buscarUsuario(usuario,  password))
            {
                this.Hide();
                var princ = new principal();
                princ.Show();
            }else
            {
                MessageBox.Show("credenciales incorrectas", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
