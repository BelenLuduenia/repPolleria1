using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAA;

namespace Polleria
{
    public partial class Facturación : Form
    {

        #region propiedades

        Factura objetoFact = new Factura();
        RngFactura objRngFact;
        Decimal total = 0;


        #endregion


        #region constructor
        public Facturación()
        {
            InitializeComponent();



        }

        #endregion



        #region eventos

        //Bt confirmar
        private void btnconfirmar_Click(object sender, EventArgs e)
        {

            if (txtNombre1.Text == "" || txtApellido1.Text == "" || txtDNI1.Text == "" || txtnumeroFact.Text == "") // si en la propiedad text borrado todos los espacios en blanco de principio a final es igual a vacio entonces, 
            {
                lblErrorEncabezado.Text = " falta datos del encabezado "; // este lbl no se ve en el formulario pero si no se llenan todos los campos aparece 


                // este es un metodo pero que no tiene argumento y lo que hace es poner foco en el txtnumero en este caso.
            }
            else
            {

                lblErrorEncabezado.Text = "";
                panelrenglones.Enabled = true;
                limpiarRenglones();

            }

        }


        //boton carga productos
        private void btnNuevoRenglon_Click(object sender, EventArgs e)
        {


            limpiarRenglones();

            objRngFact = new RngFactura();
            objRngFact.Cantidad = Convert.ToDecimal(cboxCantidad.Text);
            objRngFact.kg = Convert.ToDecimal(cboxKilo.Text);
            objRngFact.Producto = (cboxProducto.Text);
            txtTotales.Text = objRngFact.Total().ToString("  #,##0.00");


            cboxCantidad.Text = "";
            cboxProducto.Text = "";
            cboxKilo.Text = "";



            objetoFact.AddRngfactura(objRngFact);

            MuetraRenglones();

            bruto();


            // el lbl iva, en su propiedad text, toma el valor que  resulte de calcular el metodo (calcularIva), que esta en la clase factura.
            lblIva.Text = objetoFact.CalcularIva().ToString(" #,##0.00");


            //el lbl total, en su propiedad text,toma el valor que resulte de calcular el metodo (calcularTotal), que esta en la clase factura.
            lblTotal.Text = objetoFact.CalcularTotal().ToString(" #,##0.00");





        }

        //boton volver
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Clientes a = new Clientes();
            a.Show();
            this.Close();


        }


        //boton Imprimir

        private void btnImprimir_Click(object sender, EventArgs e)
        {


            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir;
            printDocument1.Print();



        }


        // boton calcular devolucion

        private void btnCalcularDevolucion_Click(object sender, EventArgs e)
        {

            txtEfectivo.Focus();
            objetoFact.efectivo = Convert.ToDecimal(txtEfectivo.Text);


            lblDevolucion.Text = objetoFact.calcularDevolución().ToString(" #,##0.00");



        }

        #endregion


        #region metodos

        private void limpiarRenglones()
        {

            cboxCantidad.Focus();


        }

        private void MuetraRenglones()
        {
            // todo: mostrar todos los renglones
            lblRenglon.Text = objetoFact.MuestraRenglones(); //  la propiedad text de lblrenglon, va a llamar a un metodo muestrarenglon del objeto rngfactura, el metodo 
            // muetrarenglon esta en rngfactura 
        }

        private void bruto()
        {
            total = total + (objRngFact.Total());
            lblBruto.Text = (total).ToString();

            // ahora mi propiedad Bruto, de la clase factura, toma el valor del label bruto
            objetoFact.Bruto = System.Convert.ToDecimal(lblBruto.Text);
        }


        private void Imprimir(object sender, PrintPageEventArgs e)
        {

            Font font = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Point);

            int ancho = 1000;
            int y = 20;

            e.Graphics.DrawString("POLLERIA YANIBEL", font, Brushes.Red, new RectangleF(120, y += 20, ancho, 1000));
            e.Graphics.DrawString("-------------------------------------------------------------------", font, Brushes.Blue, new RectangleF(0, y += 20, ancho, 1000));
            e.Graphics.DrawString("Mendoza 616 - MALVINAS ARGENTINAS", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 1000));
            e.Graphics.DrawString("TELEFONO: (0351) 155196649 - C.P.5125 - CBA", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 1000));
            e.Graphics.DrawString("IVA RESPONABLE INSCRIPTO", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 1000));
            e.Graphics.DrawString("A CONSUMIDOR FINAL", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 1000));
            e.Graphics.DrawString("-------------------------------------------------------------------", font, Brushes.Blue, new RectangleF(0, y += 20, ancho, 1000));

            e.Graphics.DrawString("Factura#" + txtnumeroFact.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 1000));
            e.Graphics.DrawString("Fecha:" + txtFecha1.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 1000));
            e.Graphics.DrawString("Hora:" + txtHora.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 1000));

            e.Graphics.DrawString("Nombre:" + txtNombre1.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 1000));
            e.Graphics.DrawString("Apellido:" + txtApellido1.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 1000));
            e.Graphics.DrawString("DNI:" + txtDNI1.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 1000));
            e.Graphics.DrawString("-------------------------------------------------------------------", font, Brushes.Blue, new RectangleF(0, y += 20, ancho, 1000));

            e.Graphics.DrawString("Productos", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 1000));
            e.Graphics.DrawString(lblRenglon.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 1000));
            e.Graphics.DrawString("-------------------------------------------------------------------", font, Brushes.Blue, new RectangleF(0, y += 160, ancho, 1000));

            e.Graphics.DrawString("Bruto:$" + lblBruto.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 1000));
            e.Graphics.DrawString("IVA:$" + lblIva.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 1000));
            e.Graphics.DrawString("Neto:$" + lblTotal.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 1000));
            e.Graphics.DrawString("Su pago:$" + txtEfectivo.Text, font, Brushes.Black, new RectangleF(0, y += 30, ancho, 1000));
            e.Graphics.DrawString("Su vuelto:$" + lblDevolucion.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 1000));
            e.Graphics.DrawString("-------------------------------------------------------------------", font, Brushes.Blue, new RectangleF(0, y += 20, ancho, 1000));

            e.Graphics.DrawString("GRACIAS POR SU COMPRA!!!!!", font, Brushes.Red, new RectangleF(0, y += 30, ancho, 1000));


        }



        #endregion

        private void Facturación_Load(object sender, EventArgs e)
        {

        }
    }
}
