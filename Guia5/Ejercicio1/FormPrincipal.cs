using System;
using System.Windows.Forms;
using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class FormPrincipal : Form
    {
        Presupuesto p;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnCerrarPresupuesto_Click(object sender, EventArgs e)
        {
            string[] lista = p.Resumen();

            FormVer fVer = new FormVer();

            fVer.lbxVer.Items.AddRange(lista);
            //foreach (string linea in lista)
            //{
            //    fVer.lbxVer.Items.Add(linea);
            //}

            fVer.ShowDialog();

            cmbProducto.Items.Clear();
            p = null;
        }

        private void btnBorrarProducto_Click(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedItem != null)
            {
                int codigo = Convert.ToInt32(cmbProducto.SelectedItem);
                p.QuitarProducto(codigo);
            }

            //Producto p = cmbProducto.SelectedItem as Producto;
            //if (p != null)
            //{ 

            //    int codigo = p.Codigo;

            //    this.p.QuitarProducto(codigo);
            //}



            //si trabajo con objetos en el combobox - ojo! necesito el tostring en producto
            //Producto selected = cmbProducto.SelectedItem as Producto;
            //if (selected != null)
            //     p.QuitarProducto(selected.Codigo)
        }


        private void btnIniciarPrespuesto_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            string direccion = tbDireccion.Text;
            p = new Presupuesto(nombre, direccion);
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto selected = null;
            if (rbBanco.Checked)
            {
                selected = new Banco(23, 23);
            }
            else if (rbMesa.Checked)
            {
                selected = new Mesa(23, 23, 23);
            }


            if (p != null)
            {
                if (selected != null)
                {
                    p.AgregarProducto(selected);

                    // cmbProducto.Items.Add(selected.Codigo);
                    cmbProducto.Items.Add(selected);
                }
                else
                { //seleccione un tipo
                }
            }
            else
            {//cree el presupuest
            }
        }
    }
}
