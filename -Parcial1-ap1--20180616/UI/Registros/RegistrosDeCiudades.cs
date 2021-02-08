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

        
    }
}
