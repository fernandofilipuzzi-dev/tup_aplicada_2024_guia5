using System;
using System.Collections;

namespace Ejercicio1.Models
{

    class Presupuesto
    {
        //forma 1 de calcular el precio
        public double Precio 
        {
            get 
            {
                double total = 0;
                foreach(Producto p in listaProductos)
                {
                    total += p.Precio();//polimorfismo!
                }
                return total;
            }
        }

        //forma 2de calcular el precio -(a) necesito un getter/setter completo
        //public double Precio { get; set; }

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

            //forma 2de calcular el precio -(b)acumulo aquí
            //Precio+=producto.Precio(); //polimorfismo!
        }

        public bool QuitarProducto(int codigo)
        {
            listaProductos.Sort();

            Producto buscado = BuscarProducto(codigo);
            if (buscado != null)
            {
                listaProductos.Remove(buscado);

                //forma 2de calcular el precio -(c)devo aquí actualizar el precio
                //Precio-=buscado.Precio(); //polimorfismo!

                return true;
            }
         
            return false;
        }

        /*alternativa 1: realizando el algoritmo*/
        public Producto BuscarProducto(int codigo)
        {
            int inf = 0, sup= listaProductos.Count-1;
            int centro = (sup + inf) / 2;
            while (inf<=sup)
            {
                Producto prueba = listaProductos[centro] as Producto;

                if (prueba == null) return null;//verificación!

                if (prueba.Codigo == codigo) return prueba;
                else if (codigo < prueba.Codigo) sup = centro-1;
                else inf = centro + 1;

                centro = (sup + inf) / 2;
            }

            return null;
        }

        /*alternativa 2: usando el binarysearch del arraylist  - planteada por pancho
         
        public Producto BuscarProducto(int codigo)
        {
            Banco pedido = new Banco(0, 0);//objeto de prueba - podría usar Mesa tambien.
            pedido.Codigo = codigo;
            int idx = listaProductos.BinarySearch(pedido);
            if (idx >= 0)
            {
                return listaProductos[idx] as Producto; //ojo! si se usa list no necesitan castear                
            }
            return null;
        }
        
         */

        public string[] Resumen()
        {
            string[] result = new string[listaProductos.Count+2];

            int n = 0;
            result[n++]=solicitante.ToString();
            foreach (Producto p in listaProductos)
            {
                result[n++]=p.ToString();
            }
            result[n++] = $"Total: ${Precio}";
            return result;
        }

    }
}
