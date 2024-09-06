
using System.Collections;

namespace Ejercicio1.Models
{
    public class Banco : Producto
    {
        public Banco(double precio, double largo) : base(precio, largo)
        {
        }

        public override double Peso()
        {
            return largo * 0.25 * 0.42;
        }

        public override double Precio()
        {
            return Peso() * precioBase * 1.15;
        }
    }
}
