using System;
using System.Windows.Forms;
using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class FormPrincipal : Form
    {
        Presupuesto pedido;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnCerrarPresupuesto_Click(object sender, EventArgs e)
        {
            /*Implemente el botón Cerrar pedido que cierre el pedido e informe en pantalla el precio final.*/

            //informando
            string[] lista = pedido.Resumen();

            FormVer fVer = new FormVer();

            /*alternativa 1 para llenar un listbox*/
            fVer.lbxVer.Items.AddRange(lista);

            /*alternativa 2 para llenar un listbox
            foreach (string linea in lista)
            {
                fVer.lbxVer.Items.Add(linea);
            }
            */

            fVer.ShowDialog();

            cmbProducto.Items.Clear();
            pedido = null;
        }

        private void btnBorrarProducto_Click(object sender, EventArgs e)
        {
            /*Implemente el botón Borrar que quite el producto seleccionado en el ComboBox1 del presupuesto, utilizando un método de búsqueda binaria dentro del método BuscarProducto
            */

            /*alternativa 1- tomando el entero agregado al combobox*/
            if (cmbProducto.SelectedItem != null)
            {
                int codigo = Convert.ToInt32(cmbProducto.SelectedItem);
                pedido.QuitarProducto(codigo);

                cmbProducto.Items.Remove(cmbProducto.SelectedItem);//los items funcionan como los arraylist
                cmbProducto.Text = "";//detallito!
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto");
            }

            /*altenativa 2 cuando se agregan objetos al combobox
            Producto selectedProducto = cmbProducto.SelectedItem as Producto;
            if (selectedProducto != null)
            { 
                pedido.QuitarProducto(selectedProducto.Codigo);

                cmbProducto.Items.Remove(selectedProducto);//los items funcionan como los arraylist
                cmbProducto.Text = "";//detallito!
            }
            */
        }

        private void btnIniciarPrespuesto_Click(object sender, EventArgs e)
        {
            //Implemente el botón Iniciar Presupuesto que permita iniciar un pedido
            string nombre = tbNombre.Text;
            string direccion = tbDir.Text;
            pedido = new Presupuesto(nombre, direccion);
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Implemente el botón Agregar que permita crear una mesa o un banco y agregarlo a la lista de productos y mostrar su código en el comboBox1. Ejemplos:
            //10016080: mesa de 160x80
            //300200: banco de 200


            double precioBase = Convert.ToInt32(tbPrecioBase.Text);
            double largo = Convert.ToInt32(tbLargo.Text);
            int codigo = Convert.ToInt32(tbCodigo.Text);

            Producto nuevo = null;
            if (rbBanco.Checked)
            {
                nuevo = new Banco(precioBase, largo);
                nuevo.Codigo = codigo;
            }
            else if (rbMesa.Checked)
            {
                double ancho = Convert.ToInt32(tbAncho.Text);
                double grosor = Convert.ToInt32(tbGrosor.Text);

                nuevo = new Mesa(precioBase, largo, ancho, grosor);
                nuevo.Codigo = codigo;
            }

            if (pedido != null)
            {
                if (nuevo != null)
                {
                    pedido.AgregarProducto(nuevo);

                    //alternativa 1 - trabajando con el codigo
                    cmbProducto.Items.Add(codigo);

                    /*alternativa 2 - si cargo el combo con objetosproductos y noenteros
                    cmbProducto.Items.Add(nuevo.Codigo);
                    */
                }
                else
                {
                    MessageBox.Show("seleccione un tipo");
                }
            }
            else
            {
                MessageBox.Show("cree el presupuesto");
            }
        }
    }
}
