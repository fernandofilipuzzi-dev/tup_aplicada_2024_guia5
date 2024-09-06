using System;

namespace Ejercicio1.Models
{

    public class Cliente
    {
        string nombre;
        string direccion;
     
        public Cliente(string nombre, string dir)
        {
            this.nombre = nombre;
            this.direccion = dir;
        }
        
        public override string ToString()
        {
            return $"{nombre}  ( {direccion} )";
        }

    }
}
