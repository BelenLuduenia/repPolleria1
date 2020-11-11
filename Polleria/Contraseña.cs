using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polleria
{
    public partial class Contraseña : Form
    {
        #region propiedades

        // propiedades
        string usuario = "belen";
        int contraseña = 111;

        #endregion


        #region constructor

        public Contraseña()
        {
            InitializeComponent();
        }

        #endregion

        #region eventos

        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            LimpiarEncabezados();
            if (txtUsuario.Text != usuario || txtContraseña.Text != contraseña.ToString())
            {
                if (txtUsuario.Text != usuario)
                {
                    errorProvider1.SetError(txtUsuario, "usuario incorrecto");

                    txtUsuario.Clear();
                    txtUsuario.Focus();

                }
                else
                {
                    errorProvider1.SetError(txtUsuario, "");
                }

                if (txtContraseña.Text != contraseña.ToString())
                {
                    errorProvider2.SetError(txtContraseña, " contaseña incorrecta");

                    txtContraseña.Clear();
                    txtContraseña.Focus();

                }
                else
                {
                    errorProvider1.SetError(txtContraseña, "");
                }



            }
            else
            {
                this.Close();
                txtUsuario.Clear();
                txtContraseña.Clear();

                CPF R = new CPF();
                R.Show();

            }


        }
        //boton salir
        private void BtnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion


        #region metodos
        // metodo para limpiar encabezados
        private void LimpiarEncabezados()
        {
            txtUsuario.Text = txtUsuario.Text.Trim();
            txtContraseña.Text = txtContraseña.Text.Trim();

        }


        #endregion


       
    }
}
