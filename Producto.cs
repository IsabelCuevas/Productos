using System;


namespace Productos
{
    class Producto:IPagar

    {
        #region Atributos
        private string nombre;
        private int clave;
        private byte cantidad;
        private byte cantidadExistente;
        private float precioUnitario;
        #endregion

        #region Propiedades
        public string Nombre { 
            get => nombre; 
            set => nombre = value; 
        }
        public int Clave { 
            get => clave; 
            set => clave = value;
        }
        public byte Cantidad { 
            get => cantidad; 
            set => cantidad = value; }
        public byte CantidadExistente { 
            get => cantidadExistente;
            set => cantidadExistente = value;
        }
        public float PrecioUnitario { 
            get => precioUnitario; 
            set => precioUnitario = value;
        }

        public Producto()
        {

        }

        public void PagarEfectivo()
        {
            Console.WriteLine("Realizaste tu pago en efectivo");
        }

        public void PagarTarjeta()
        {
            Console.WriteLine("Realizaste tu pago con tarjeta");
        }
        #endregion


    }
}
