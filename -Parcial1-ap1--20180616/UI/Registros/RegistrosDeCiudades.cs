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

        private bool LlenarCampos(int id)
        {
            Ciudades ciudades = new Ciudades();
            ciudades = CiudadesBLL.Buscar(id);
            if (ciudades != null)
            {
                CiudadIdNumericUpDown.Value = ciudades.CiudadId;
                CiudadNombreTextBox.Text = ciudades.CiudadNombre;
                return true;
            }
            else
                return false;
        }

        private bool Validar()
        {
            bool paso = true;

            if (CiudadIdNumericUpDown.Value == 0)
            {
                CiudadesErrorProvider.SetError(CiudadIdNumericUpDown, "Campo obligatorio");
                paso = false;
            }

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
            CiudadNombreTextBox.Clear();
            ciudades = CiudadesBLL.Buscar(id);
            
            if (ciudades != null)
            {
                LlenarCampos(id);
                MessageBox.Show("Ciudad Encontrada");
            }
            else
                MessageBox.Show("La ciudad no ha sido encontrada");
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Ciudades ciudades = new Ciudades();
            bool paso = false;
            int id = (int)CiudadIdNumericUpDown.Value;
            string nombre = CiudadNombreTextBox.Text;

            if (!Validar())
                return;

            ciudades = LlenarClase();
            if (CiudadIdNumericUpDown.Value != 0)
            {
                if (CiudadesBLL.ExisteNombre(id, nombre))
                {
                    MessageBox.Show("La ciudad ya existe en la base de datos, no puede agregarla a la base de datos");
                    return;
                }
                paso = CiudadesBLL.Guardar(ciudades);
                MessageBox.Show("La ciudad ha sido guardada con exito");
            }
            else
            {
                if (!ExisteEnBaseDatos())
                {
                    MessageBox.Show("Esta ciudad no existe en la base de datos");
                    return;
                }
                paso = CiudadesBLL.Modificar(ciudades);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = (int)CiudadIdNumericUpDown.Value;
            CiudadesErrorProvider.Clear();
            if (CiudadesBLL.Eliminar(id))
            {
                MessageBox.Show("La ciudad ha sido eliminada");
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
