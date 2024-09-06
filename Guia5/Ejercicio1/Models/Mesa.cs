using System;

namespace Ejercicio1.Models
{
    public class Mesa :Banco
    {
        public double ancho;
        public double grosor;
        public Mesa(double precio, double largo,  double ancho,  double grosor) : base(precio, largo)
        {
            this.ancho = ancho;
            this.ancho = grosor;
        }

        //El peso de la mesa se calcula con densidad de 0,3 Kg/m3: peso = (largo*ancho*grosor) * 0.3
        public override double Peso()
        {
            return largo*ancho*grosor*0.3;
        }

        // El precio final de la mesa se calcula con: precio = peso * precioBase *1.25
        public override double Precio()
        {
            return Peso() * precioBase * 1.25;
        }
    }
}
