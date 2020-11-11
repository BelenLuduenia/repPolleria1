using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAA
{
    public class Factura
    {

        #region propiedades
        public decimal Bruto = 0;
        public decimal Iva = 0;
        public decimal Total = 0;
        public decimal devolucion = 0;
        public decimal efectivo = 0;

        public RngFactura[] listaRngFactura = new RngFactura[7]; // aca defini una nueva propiedad de la clase factura, que es un arreglo de renglones de factura 
        private int indice = 0;

        #endregion



        #region metodos
        public void AddRngfactura(RngFactura objRngFact) // o renglon, ya que puede tener cualquier nombre
        {
            // todo: controlar error de sobrepasar capacidad del arreglo
            listaRngFactura[indice] = objRngFact;

            indice = indice + 1; // el indice me permite incorporar un elemento nuevo 

        }

        public string MuestraRenglones() // me muestra todos los renglones de la factura
        {
            string RenglonesTxt = "";

            for (int i = 0; i < indice; i++)
            {

                RenglonesTxt = RenglonesTxt + listaRngFactura[i].MuestraRenglon() + "\r\n";

            }
            return RenglonesTxt;
        }


        // metodo para calcular IVA

        public decimal CalcularIva()
        {
            decimal calciva = 0.21m;
            return Bruto * (calciva);
        }

        // metodo para calcular total

        public decimal CalcularTotal()
        {

            return Bruto + CalcularIva();
        }

        // calcular devolucion;

        public decimal calcularDevolución()
        {

            return efectivo - CalcularTotal();


        }

        #endregion




    }


    

    


}
