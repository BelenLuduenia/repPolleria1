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
    public partial class CPF : Form
    {

        #region constructor

        public CPF()
        {
            InitializeComponent();
        }

        #endregion

        #region eventos
        // abre formulario cliente
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Clientes A = new Clientes();
            A.Show();

            borrarCPF();


        }

        //abre formulario productos
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Productos p = new Productos();
            p.Show();

            borrarCPF();

        }

        // con este metodo salgo del formulario CPF
        public void borrarCPF() 
        {
            this.Close();

        }
        // boton salir 
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion








        /* private void toolStripMenuItem2_Click(object sender, EventArgs e)
         {

             Facturación B = new Facturación();
             B.Show();




         }*/

        
       
    }

}
