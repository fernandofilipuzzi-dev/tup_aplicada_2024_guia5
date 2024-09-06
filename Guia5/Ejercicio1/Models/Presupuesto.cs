using System;
using System.Collections;

namespace Ejercicio1.Models
{

    class Presupuesto
    {
        public double Precio { get; set; }
        ArrayList listaProductos=new ArrayList();

        private Cliente solicitante;
     
        public Presupuesto(string nombre, string direccion)
        {
            solicitante = new Cliente(nombre, direccion);
        }

        public void AgregarProducto(Producto producto)
        { 
            //habria que ver si no pide que no se repitan
            listaProductos.Add(producto);
        }

        public bool QuitarProducto(int codigo)
        {
            listaProductos.Sort();

            Producto p = BuscarProducto(codigo);
            if (p != null)
            {
                listaProductos.Remove(p);
                return true;
            }
         
            return false;
        }

        /*alternativa 1*/
        public Producto BuscarProducto(int codigo)
        {
            Producto prod = null;

            int inf = 0, sup= listaProductos.Count;
            int centro = (sup + inf) / 2;
            while (inf<sup)
            {
                Producto p=listaProductos[centro] as Producto;
                if (p.Codigo == codigo) return p;
                else if (codigo < p.Codigo) sup = centro-1;
                else sup = inf+1;

                centro = (sup + inf) / 2;
            }

            return prod;
        }

        /*alternativa 2: planteada por pancho
         
        public Producto BuscarProducto(int codigo)
        {
            Banco p = new Banco(0, 0);//objeto de prueba - podría usar Mesa tambien.
            p.Codigo = codigo;
            int idx = listaProductos.BinarySearch(p);
            if (idx >= 0)
            {
                return listaProductos[idx] as Producto; //ojo! si se usa list no necesitan castear                
            }
            return null;
        }
        
         */

        public string[] Resumen()
        {
            string[] result = new string[listaProductos.Count];

            int n = 0;
            foreach (Producto p in listaProductos)
            {
                result[n++]=p.ToString();
            }
            return result;
        }

    }
}
