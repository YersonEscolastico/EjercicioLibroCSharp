using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicios_LibroCSharp.Cap._9.Entidades;
using Ejercicios_LibroCSharp.Cap._9.UI.Registro;
using Ejercicios_LibroCSharp.Cap._9;
using System.Collections;

namespace Ejercicios_LibroCSharp.Cap._9.UI.Registro.Inventario_Tienda
{
    public partial class rProductos : Form
    {
        public rProductos()
        {
            InitializeComponent();
        }

        ArrayList arrayList = new ArrayList();

        public ProductosT[] productos = new ProductosT[30];



        public void Limpiar()
        {
            NombreTextBox.Text = string.Empty;
            CodigoTextBox.Text = string.Empty;
            PrecioTextBox.Text = string.Empty;
            CodigoTextBox.Text = string.Empty;
        }

        public void Agregar()
        {
            ProductosT productos = new ProductosT();
            productos.Nombre = NombreTextBox.Text;
            productos.Codigo = CodigoTextBox.Text;
            productos.Cantidad = CaantidadTextBox.Text;
            productos.Precio = PrecioTextBox.Text;
            

            arrayList.Add(productos);
            MessageBox.Show("!!Producto Guardado!!");
        }

        public void Mostrar()
        {
            DataGridView.DataSource = null;
            DataGridView.DataSource = arrayList;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Agregar();
            Limpiar();
        }

        private void MostrarButton_Click(object sender, EventArgs e)
        {
            Mostrar();
            Limpiar();
        }
    }
}
