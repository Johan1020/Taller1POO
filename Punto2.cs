namespace Taller1POO
{
    internal class Punto2
    {
        static void Main(string[] args)
        {
            Factura factura = new Factura("001", "Martillo", 5, 10);

            Console.WriteLine("Número de Pieza: " + factura.NumeroDePieza);
            Console.WriteLine("Descripción de Pieza: " + factura.DescripcionDePieza);
            Console.WriteLine("Cantidad de Artículos: " + factura.CantidadDeArticulos);
            Console.WriteLine("Precio por Artículo: " + factura.PrecioPorArticulo);
            Console.WriteLine("Monto de la Factura: " + factura.ObtenerMontoFactura());
        }

        public class Factura
        {
            public string NumeroDePieza { get; set; }
            public string DescripcionDePieza { get; set; }
            public int CantidadDeArticulos { get; set; }
            public int PrecioPorArticulo { get; set; }

            // Constructor
            public Factura(string numeroDePieza, string descripcionDePieza, int cantidadDeArticulos, int precioPorArticulo)
            {
                NumeroDePieza = numeroDePieza;
                DescripcionDePieza = descripcionDePieza;
                EstablecerCantidad(cantidadDeArticulos);
                EstablecerPrecio(precioPorArticulo);
            }
            public void EstablecerCantidad(int cantidadDeArticulos)
            {
                CantidadDeArticulos = cantidadDeArticulos > 0 ? cantidadDeArticulos : 0;
            }

            public void EstablecerPrecio(int precioPorArticulo)
            {
                PrecioPorArticulo = precioPorArticulo > 0 ? precioPorArticulo : 0;
            }
            public int ObtenerMontoFactura()
            {
                return CantidadDeArticulos * PrecioPorArticulo;
            }
        }
    }
}
