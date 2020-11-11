using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAA;


namespace Polleria
{
    public partial class Productos : Form
    {
        #region propiedades
        Cliente_producto producto;

        DataTable productos = new DataTable();
        int poc;

        #endregion


        #region constructor

        public Productos()
        {
            InitializeComponent();


            productos.TableName = "prod";
            productos.Columns.Add("Cantidad"); // agrera columna en el DGV
            productos.Columns.Add("Producto");
            productos.Columns.Add("Precio x kg");
            productos.Columns.Add("Proveedor");
            productos.Columns.Add("Teléfono");
            productos.Columns.Add("Dirección");

            dgvProductos.DataSource = productos;

            ControlBtn();



        }

        #endregion



        #region eventos

        // vuelve al formulario anterior 
        private void btnVolver_Click(object sender, EventArgs e)
        {
            CPF R = new CPF();
            R.Show();
            this.Close();
        }

        // elimina una fila
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            productos.Rows.RemoveAt(poc);


        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // creo una variable de tipo entera para la posicion y para q te seleccione la fila
            poc = dgvProductos.CurrentRow.Index;


            txtCantidad.Text = dgvProductos[0, poc].Value.ToString();

            txtProducto.Text = dgvProductos[1, poc].Value.ToString();

            txtUnitario.Text = dgvProductos[2, poc].Value.ToString();// columna 0, posicion 0 // la fila es capturada por la variable posicion

            txtProveedor.Text = dgvProductos[3, poc].Value.ToString();

            txtTel.Text = dgvProductos[4, poc].Value.ToString();

            txtDirec.Text = dgvProductos[5, poc].Value.ToString();


        }

        //boton nuevo
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();

            txtCantidad.Focus();


            ControlBtn1();
        }

        //boton modificar

        private void btnModificar_Click(object sender, EventArgs e)
        {

            dgvProductos[0, poc].Value = txtCantidad.Text;
            dgvProductos[1, poc].Value = txtProducto.Text;
            dgvProductos[2, poc].Value = txtUnitario.Text;
            dgvProductos[3, poc].Value = txtProveedor.Text;// a la columna ID en la tabla, le asigno lo que esta en mi txt producto
            dgvProductos[4, poc].Value = txtTel.Text;
            dgvProductos[5, poc].Value = txtDirec.Text;

            limpiar(); // metodo limpiar


        }

        // buscar por producto
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BindingSource ac = new BindingSource();
            ac.DataSource = dgvProductos.DataSource;
            ac.Filter = "Producto like '%" + txtBuscar.Text + "%'";
            dgvProductos.DataSource = ac;

        }


        //boton guardar

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            productos.WriteXml(@"prod.xml");



        }

        // boton leer

        private void btnLeer_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(@"prod.xml"))
            {
                productos.WriteXml(@"prod.xml");
            }

            productos.ReadXml(@"prod.xml");

            ControlBtn2();
        }


        //boton agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {


            producto = new Cliente_producto();

            producto.Codigo = Convert.ToInt32(txtCantidad.Text);
            producto.Producto = txtProducto.Text;
            producto.Unitario = Convert.ToDecimal(txtUnitario.Text);
            producto.Proveedor = txtProveedor.Text;
            producto.tel = Convert.ToInt32(txtTel.Text);
            producto.dirección = txtDirec.Text;


            productos.Rows.Add(producto.Codigo, producto.Producto, producto.Unitario, producto.Proveedor, producto.tel, producto.dirección);

            ControlBtn3();


        }


        //validacion Cantidad
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
           //08 retroceso
           

            if (( e.KeyChar >= 48 && e.KeyChar <= 57) ||(e.KeyChar==08))
            {
                errorProvider2.SetError(txtCantidad, "");
            }
            else
            {
                errorProvider2.SetError(txtCantidad, "solo numeros");
                txtCantidad.Focus();
                e.Handled = true;
                return;
            }
        }


        //validacion Producto
        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {


            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) ||(e.KeyChar==32)||( e.KeyChar==08))
            {
                errorProvider2.SetError(txtProducto, "");


            }
            else
            {
                
                errorProvider2.SetError(txtProducto, "solo letras");

                txtProducto.Focus();
                e.Handled = true;
                return;

            }

        }


        //validacion de precio/kg
        private void txtUnitario_KeyPress(object sender, KeyPressEventArgs e)
            //44 la coma
            
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 44) || (e.KeyChar == 08) )
            {

                errorProvider2.SetError(txtUnitario, "");
            }

            else
            {

                
                errorProvider2.SetError(txtUnitario, "solo numeros");
                txtUnitario.Focus();
                e.Handled = true;
                return;
            }


        }
        // validacion de Proveedor 
        private void txtProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {


            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 32) || (e.KeyChar == 08))
            {
                errorProvider2.SetError(txtProveedor, "");

            }
            else
            {
               
                errorProvider2.SetError(txtProveedor, "solo letras");

                txtProveedor.Focus();
                e.Handled = true;
                return;

            }

        }

        // validacion de telefono
        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 08))
            {
                errorProvider2.SetError(txtTel, "");

            }

            else
            {

               
                errorProvider2.SetError(txtTel, "solo numeros");
                txtTel.Focus();
                e.Handled = true;
                return;

            }


        }

        // validacion de Dirección

        private void txtDirec_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            

            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122)  || (e.KeyChar == 32) || (e.KeyChar == 08) || (e.KeyChar >= 48 && e.KeyChar <= 57))
            {
                errorProvider2.SetError(txtDirec, "");

            }
            else
            {

                errorProvider2.SetError(txtDirec, "Solo letras y numeros");

                txtDirec.Focus();
                e.Handled = true;
                return;
            }
        }



        #endregion



        #region metodos

        private void ControlBtn()
        {
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = false;
        }


        private void ControlBtn1()
        {

            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;


        }

        private void ControlBtn2()
        {

            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = true;
        }

        private void ControlBtn3()
        {
            btnModificar.Enabled = true;
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = true;

        }

        // metodo para limpiar los txt
        private void limpiar()
        {
            txtCantidad.Text = "";
            txtProducto.Text = "";
            txtUnitario.Text = "";
            txtProveedor.Text = "";
            txtTel.Text = "";
            txtDirec.Text = "";


        }





        #endregion

        

        


    }
}
