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

       
    }
}
