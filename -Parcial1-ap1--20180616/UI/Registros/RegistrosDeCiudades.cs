using _Parcial1_ap1__20180616.BLL;
using _Parcial1_ap1__20180616.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _Parcial1_ap1__20180616.UI.Registros
{
    public partial class RegistrosDeCiudades : Form
    {
        public RegistrosDeCiudades()
        {
            InitializeComponent();
        }

        private Ciudades LlenarClase()
        {
            Ciudades ciudades = new Ciudades();

            ciudades.CiudadId = (int)CiudadIdNumericUpDown.Value;
            ciudades.CiudadNombre = CiudadNombreTextBox.Text;

            return ciudades;
        }

        private void LlenarCampos(Ciudades ciudades)
        {
            CiudadIdNumericUpDown.Value = ciudades.CiudadId;
            CiudadNombreTextBox.Text = ciudades.CiudadNombre;
        }

        private bool Validar()
        {
            bool paso = true;

            if (CiudadNombreTextBox.Text == "")
            {
                CiudadesErrorProvider.SetError(CiudadNombreTextBox, "Campo obligatorio");
                paso = false;
            }

            return paso;
        }

        private void Limpiar()
        {
            CiudadIdNumericUpDown.Value = 0;
            CiudadNombreTextBox.Clear();
        }

        private bool ExisteEnBaseDatos()
        {
            Ciudades ciudades = new Ciudades();

            ciudades = CiudadesBLL.Buscar((int)CiudadIdNumericUpDown.Value);

            return (ciudades != null);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Ciudades ciudades = new Ciudades();
            int id = (int)CiudadIdNumericUpDown.Value;

            Limpiar();
            ciudades = CiudadesBLL.Buscar(id);

            if (ciudades != null)
                LlenarCampos(ciudades);
            else
                MessageBox.Show("Ciudad no encontrada ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Ciudades ciudad;

            if (!Validar())
                return;
            ciudad = LlenarClase();

            if (CiudadIdNumericUpDown.Value == 0)
                paso = CiudadesBLL.Guardar(ciudad, CiudadNombreTextBox.Text);
            else
            {
                if (!ExisteEnBaseDatos())
                {
                    MessageBox.Show("No se puede modificar una ciudad que no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = CiudadesBLL.Modificar(ciudad);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("La ciudad ha sido guardada!", "Logrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = (int)CiudadIdNumericUpDown.Value;
            CiudadesErrorProvider.Clear();
            if (CiudadesBLL.Eliminar(id))
            {
                MessageBox.Show("La ciudad ha sido eliminada", "Logrado");
                Limpiar();
            }
            else
                CiudadesErrorProvider.SetError(CiudadIdNumericUpDown, "Este Id no existe en la base de datos");
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
