﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicios_LibroCSharp.Cap._9.UI.Registro.Inventario_Tienda;


namespace Ejercicios_LibroCSharp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rProductos frm = new rProductos();
            frm.Show();
        }
    }
}