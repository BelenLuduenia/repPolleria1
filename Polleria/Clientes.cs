using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAA;






namespace Polleria
{
    public partial class Clientes : Form
    {

        #region propiedades

        // creo un objeto de la clase  clasclientes
        Cliente_producto cliente = new Cliente_producto();
        //creo objeto de tipo datatable
        DataTable clientes = new DataTable();
        int poc;
        public DateTime fecha;
        #endregion



        #region constructor

        public Clientes()
        {
            InitializeComponent();

            clientes.TableName = "datos";
            clientes.Columns.Add("ID"); // agrera columna en el DGV
            clientes.Columns.Add("DNI");
            clientes.Columns.Add("Nombre");
            clientes.Columns.Add("Apellido");
            clientes.Columns.Add("Teléfono");
            clientes.Columns.Add("Dirección");

            dgvClientes.DataSource = clientes;


            ControlBtn();


        }

        #endregion



        #region eventos

        // boton agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            cliente = new Cliente_producto();

            cliente.id = Convert.ToInt32(txtID.Text);
            cliente.dni = Convert.ToInt32(txtDni.Text);
            cliente.nombre = txtNombre.Text;
            cliente.apellido = txtApellido.Text;
            cliente.telefono = Convert.ToInt32(txtTelefono.Text);
            cliente.direccion = txtDirección.Text;


            clientes.Rows.Add(cliente.id, cliente.dni, cliente.nombre, cliente.apellido, cliente.telefono, cliente.direccion);

            ControlBtn1();


        }

        // boton volver 
        private void btnVolver_Click(object sender, EventArgs e)
        {
            CPF R = new CPF(); // vuelve al formulario anterior 
            R.Show();
            this.Close(); // cierra el formulario actual

        }


        //boton eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            clientes.Rows.RemoveAt(poc); // quita de la coleccion la fila en la posicion especificada

        }

        // boton modificar
        private void btnModificar_Click(object sender, EventArgs e)
        {

            dgvClientes[0, poc].Value = txtID.Text;
            dgvClientes[1, poc].Value = txtDni.Text;
            dgvClientes[2, poc].Value = txtNombre.Text;
            dgvClientes[3, poc].Value = txtApellido.Text;// a la columna ID en la tabla, le asigno lo que esta en mi txt producto
            dgvClientes[4, poc].Value = txtTelefono.Text;
            dgvClientes[5, poc].Value = txtDirección.Text;

            limpiar(); // metodo limpiar

        }
        //boton guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clientes.TableName = "datos";
            clientes.WriteXml(@"datos.xml");



        }

        // boton nuevo
        private void btnNuevo_Click(object sender, EventArgs e)
        {

            limpiar();// metodo limpiar los txt

            ControlBtn3();

        }

       

        //boton leer
        private void btnLeer_Click(object sender, EventArgs e)
        {


            if (!System.IO.File.Exists(@"datos.xml"))
            {
                clientes.WriteXml(@"datos.xml");
            }

            clientes.ReadXml(@"datos.xml");


            ControlBtn2();


        }

        // enviar datos a la factura 
        private void btEnviar_Click(object sender, EventArgs e)
        {
            datosclientes();


        }

        // buscar por telefono
        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            BindingSource bd = new BindingSource();
            bd.DataSource = dgvClientes.DataSource;
            bd.Filter = "Teléfono like '%" + txtBuscar.Text + "%'";
            dgvClientes.DataSource = bd;


        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // creo una variable de tipo entera para la posicion y para q te seleccione la fila
            poc = dgvClientes.CurrentRow.Index;


            txtID.Text = dgvClientes[0, poc].Value.ToString();// columna 0, posicion 0 // la fila es capturada por la variable posicion

            txtDni.Text = dgvClientes[1, poc].Value.ToString();

            txtNombre.Text = dgvClientes[2, poc].Value.ToString();

            txtApellido.Text = dgvClientes[3, poc].Value.ToString();

            txtTelefono.Text = dgvClientes[4, poc].Value.ToString();

            txtDirección.Text = dgvClientes[5, poc].Value.ToString();


        }



        // validacion de ID
        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {


            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 08))
            {

                errorProvider1.SetError(txtID, "");
            }

            else
            {

               
                errorProvider1.SetError(txtID, "solo numeros");
                txtID.Focus();
                e.Handled = true;
                return;

            }

        }

        // validacion de DNI

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 08))
            {

                errorProvider1.SetError(txtDni, "");
            }
            else
            {
               

                errorProvider1.SetError(txtDni, "solo numeros");
                txtDni.Focus();
                e.Handled = true;
                return;
            }

        }



        // validar nombre
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 32) || (e.KeyChar == 08))
            {

                errorProvider1.SetError(txtNombre, "");
            }
            else
            {
               
                errorProvider1.SetError(txtNombre, "solo letras");

                txtNombre.Focus();
                e.Handled = true;
                return;
            }

        }




        // validar apellido
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {


            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122)  || (e.KeyChar == 32) || (e.KeyChar == 08))
            {
                errorProvider1.SetError(txtApellido, "");

            }
            else
            {
              
                errorProvider1.SetError(txtApellido, "solo letras");
                txtApellido.Focus();
                e.Handled = true;
                return;
            }

        }


        // validar telefono
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 08))
            {
                errorProvider1.SetError(txtTelefono, "");

            }
            else
            {
               
                errorProvider1.SetError(txtTelefono, "solo numeros");

                txtTelefono.Focus();
                e.Handled = true;
                return;

            }

        }

        // validar direccion


        private void txtDirección_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 32) || (e.KeyChar == 08) || (e.KeyChar >= 48 && e.KeyChar <= 57))
            {
                errorProvider1.SetError(txtDirección, "");
            }
            else
            {
               
             
                errorProvider1.SetError(txtDirección, " solo numeros y letras");
                txtDirección.Focus();
                e.Handled = true;
                return;

            }

        }
       



        #endregion



        #region metodos

        // controla la visibilidad de los botones
        private void ControlBtn()
        {

            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = false;
            btEnviar.Enabled = false;


        }
        private void ControlBtn1()
        {

            btnModificar.Enabled = true;
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = true;
            btEnviar.Enabled = true;

        }

        
        private void ControlBtn2()
        {
            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = true;
            btEnviar.Enabled = true;
        }

        private void ControlBtn3()
        {

            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
            btEnviar.Enabled = false;
        }

        // metodo para limpiar los txt
        private void limpiar()
        {
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtID.Text = "";
            txtDni.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtDirección.Text = "";


        }

        // metodo para trasladar los txt a la factura
        public void datosclientes()
        {
            Facturación B = new Facturación();

            B.txtNombre1.Text = txtNombre.Text;
            B.txtApellido1.Text = txtApellido.Text;
            B.txtDNI1.Text = txtDni.Text;
            B.txtFecha1.Text = DateTime.Now.ToString("dd/MM/yyyyy");
            B.txtHora.Text = DateTime.Now.ToString("HH:mm");
            B.Show();
            this.Close();

        }







        #endregion

        
    }
}

