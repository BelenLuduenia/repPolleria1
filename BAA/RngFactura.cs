using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BAA
{
    public class RngFactura
    {

        #region propiedades
        public decimal Cantidad = 0;
        public string Producto = ""; // tiene el valor inicial  vacio
        public decimal kg = 0;


        #endregion



        #region metodos
        public decimal Total()
        {
            return Cantidad * kg;


        }



        public string MuestraRenglon()
        {
            return Cantidad.ToString(" #,##0.00 kg") + " - "
                + Producto + " - "
                + kg.ToString("$ #,##0.00 kg") + " -  "
                + Total().ToString("$ #,##0.00");


        }

        #endregion



    }
}
