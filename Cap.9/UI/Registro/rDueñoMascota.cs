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

namespace Ejercicios_LibroCSharp.Cap._9.UI.Registro
{
    public partial class rDueñoMascota : Form
    {
        public rDueñoMascota()
        {
            InitializeComponent();
        }

        ArrayList arrayList = new ArrayList();

        public DueñoMascota DueñoMascota = new DueñoMascota();


        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (NombreDTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(NombreDTextBox, "Este campo no puede estar vacio");
                NombreDTextBox.Focus();
                paso = false;
            }
            if (EdadTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(EdadTextBox, "Este campo no puede estar vacio");
                EdadTextBox.Focus();
                paso = false;
            }
            if (SexoDTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(SexoDTextBox, "Este campo no puede estar vacio");
                SexoDTextBox.Focus();
                paso = false;
            }

            if (NombreMTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(NombreMTextBox, "No puede dejar este campo vacio");
                NombreMTextBox.Focus();
                paso = false;
            }
            if (DuenoTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(DuenoTextBox, "No puede dejar este campo vacio");
                DuenoTextBox.Focus();
                paso = false;
            }
            if (SexoTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(SexoTextBox, "No puede dejar este campo vacio");
                SexoTextBox.Focus();
                paso = false;
            }
            return paso;
        }

        public void Limpiar()
        {
            NombreDTextBox.Text = string.Empty;
            EdadTextBox.Text = string.Empty;
            SexoDTextBox.Text = string.Empty;
            NombreMTextBox.Text = string.Empty;
            DuenoTextBox.Text = string.Empty;
            SexoTextBox.Text = string.Empty;
        }

        public void Agregar()
        {
            DueñoMascota dueño = new DueñoMascota();
            dueño.NombreD = NombreDTextBox.Text;
            dueño.edadD = EdadTextBox.Text;
            dueño.sexoD = SexoDTextBox.Text;
            dueño.NombreMascota = NombreMTextBox.Text;
            dueño.DueñoMascot = DuenoTextBox.Text;
            dueño.sexoMascota = SexoTextBox.Text;

            arrayList.Add(dueño);
            MessageBox.Show("!!Informacion Guardadas!!");
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
            if(Validar())

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
