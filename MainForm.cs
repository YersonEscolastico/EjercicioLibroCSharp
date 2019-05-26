using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicios_LibroCSharp.Cap._9.UI.Registro.Inventario_Tienda;
using Ejercicios_LibroCSharp.Cap._9.UI.Registro;
using Ejercicios_LibroCSharp.Cap._10.UI.Registro;


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

        private void Ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rDueñoMascota frm = new rDueñoMascota();
            frm.Show();
        }

        private void Ejercicio1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rInventarioT frm = new rInventarioT();
            frm.Show();
        }

        private void Ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rEstudiante frm = new rEstudiante();
            frm.Show();
        }
    }
}
