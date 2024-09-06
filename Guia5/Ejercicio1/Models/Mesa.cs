using System;

namespace Ejercicio1.Models
{
    public class Mesa :Banco
    {
        public double ancho;
        public double grosor;
        public Mesa(double precio, double largo, double grosor) : base(precio, largo)
        {
        }

        public override double Peso()
        {
            return largo*ancho*grosor*0.3;
        }

        public override double Precio()
        {
            return Peso() * precioBase * 1.25;
        }

    }
}
