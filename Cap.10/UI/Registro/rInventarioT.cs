﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicios_LibroCSharp.Cap._10.Entidades;
using Ejercicios_LibroCSharp.Cap._10.UI.Registro;
using Ejercicios_LibroCSharp.Cap._10;

namespace Ejercicios_LibroCSharp.Cap._10.UI.Registro
{
    public partial class rInventarioT : Form
    {
        public rInventarioT()
        {
            InitializeComponent();
        }

        ArrayList arrayList = new ArrayList();

        public InventarioTienda [] productos = new InventarioTienda [30];


        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (DescripcionTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(DescripcionTextBox, "Este campo no puede estar vacio");
                DescripcionTextBox.Focus();
                paso = false;
            }
            if (PrecioTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(PrecioTextBox, "Este campo no puede estar vacio");
                PrecioTextBox.Focus();
                paso = false;
            }
            if (CantidadTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(CantidadTextBox, "Este campo no puede estar vacio");
                CantidadTextBox.Focus();
                paso = false;
            }
            return paso;
        }


        public void Limpiar()
        {
            IdNumericUpDown.Text = string.Empty;
            DescripcionTextBox.Text = string.Empty;
            PrecioTextBox.Text = string.Empty;
            CantidadTextBox.Text = string.Empty;
        }

        public void Agregar()
        {
            InventarioTienda inventario = new  InventarioTienda();
            inventario.Precio = PrecioTextBox.Text;
            inventario.Nombre = DescripcionTextBox.Text;
            inventario.Precio = PrecioTextBox.Text;
            inventario.Cantidad = CantidadTextBox.Text;
            inventario.ProductoId = IdNumericUpDown.Text;

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
            if (Validar()) 
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
