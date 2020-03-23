using System;
using System.Windows.Forms;

namespace Productos
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Producto miProducto = new Producto();
            IPagar pagar = (IPagar)miProducto;
            pagar.PagarEfectivo();
        }
    }
}
