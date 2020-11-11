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
    public partial class FrmInicio : Form
    {


        #region constructor

        public FrmInicio()
        {
            InitializeComponent();
        }

        #endregion


        #region Eventos


        // ingresa al formulario de contraseña
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ControlLbl();

            saludo();


            movimientoImagen();


            Contraseña c = new Contraseña(); // llamo al formulario de la contraseña 
            c.Show();
            this.Hide();
        }

        // salir

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); // cierra el programa
        }

        #endregion



        #region Metodos

        // metodo saludo
        private void saludo()
        {

            string[] saludo = new string[] { "Cargando...", "aguarde", "un", "momento" };

            txtHola.Text = saludo[0] + "\r\n" + saludo[1] + "\r\n" + saludo[2] + "\r\n" + saludo[3];


        }

        // metodo de movimiento de imagenes 

        private void movimientoImagen()
        {
            Random Generador = new Random();

            int AnchoFormulario = this.Width;
            int AltoFormulario = this.Height;

            int Ancholabel = lbl.Width;

            int Altolabel1 = lbl.Height;


            //int Ancholabel2 = lbl2.Width;
            //int Altolabel2 = lbl2.Height;


            int AnchoBorde = 20;

            int X = 0;
            int paso = 1;
            int paso1 = -1;
            int Y = 0;

            int Repeticion = 0;
            int TotalRepeticion = 1;

            do
            {


                while (X < AnchoFormulario - Ancholabel - AnchoBorde & Y < AltoFormulario - Altolabel1 - AnchoBorde)
                {

                    lbl.Left = X;
                    this.Refresh();
                    X = X + paso;



                    lbl1.Top = Y;
                    this.Refresh();
                    Y = Y + paso;



                    //lbl2.Left = X;
                    //this.Refresh();
                    //X = X + paso;

                    //lbl2.Top = Y;
                    //this.Refresh();
                    //Y = Y + paso;


                }

                do
                {



                    lbl.Left = X;
                    this.Refresh();
                    X = X + paso1;



                    lbl1.Top = Y;
                    this.Refresh();
                    Y = Y + paso1;



                    //lbl2.Left = X;
                    this.Refresh();
                    X = X + paso1;

                    //lbl2.Top = Y;
                    this.Refresh();
                    Y = Y + paso1;



                } while (X > 0 & Y > 0);



                Repeticion = Repeticion + 1;


            } while (Repeticion < TotalRepeticion);



        }


        private void ControlLbl()
        {
            pictureBox1.Visible = false;
            lbl4.Visible = false;

            lbl.Visible = true;
            lbl1.Visible = true;

            txtHola.Visible = true;
        }



        #endregion



       






        

        
    }
}
