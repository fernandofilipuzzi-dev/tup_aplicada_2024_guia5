﻿
using System.Collections;

namespace Ejercicio1.Models
{
    public class Banco : Producto
    {
        public Banco(double precio, double largo) : base(precio, largo)
        {
        }

        //El peso del banco se calcula con una densidad de 0,42 Kg/m3: peso = (largo*0.25) * 0.42
        public override double Peso()
        {
            return largo * 0.25 * 0.42;
        }

        //El precio final del banco se calcula con: precio = peso * precioBase *1.15
        public override double Precio()
        {
            return Peso() * precioBase * 1.15;
        }
    }
}
