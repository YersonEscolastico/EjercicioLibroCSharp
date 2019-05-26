using System;
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
    public partial class rEstudiante : Form
    {
        public rEstudiante()
        {
            InitializeComponent();
        }

        ArrayList arrayList = new ArrayList();

        public Estudiante [] productos = new Estudiante[30];

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (NombreTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(NombreTextBox, "Este campo no puede estar vacio");
                NombreTextBox.Focus();
                paso = false;
            }
            if (PadreTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(MadreTextBox, "Este campo no puede estar vacio");
                MadreTextBox.Focus();
                paso = false;
            }
            return paso;
        }

        public void Limpiar()
        {
            NombreTextBox.Text = string.Empty;
            PadreTextBox.Text = string.Empty;
            MadreTextBox.Text = string.Empty;
        }

        public void Agregar()
        {
            Estudiante estudiante = new Estudiante();
            estudiante.Nombre = NombreTextBox.Text;
            estudiante.Padre = PadreTextBox.Text;
            estudiante.Madre = MadreTextBox.Text;
         
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

        private void AgregarButton_Click(object sender, EventArgs e)
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
