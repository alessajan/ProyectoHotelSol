using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoHotelSol
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(BDcs mBD = new BDcs())
            {
                if (mBD.Conectar())
                {
                    string user = TxtUser.Text;
                    string contra = TxtContra.Text;

                    if(mBD.ValidarUsuario(user, contra))
                    {
                        MessageBox.Show("Inicio exitoso");

                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos");
                    }
                    mBD.Desconectar();
                }
                else
                {
                    MessageBox.Show("No se pudo conectar a la base de datos");
                }
            }
        }
    }
}
