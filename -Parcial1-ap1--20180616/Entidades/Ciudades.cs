using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _Parcial1_ap1__20180616.Entidades
{
    public class Ciudades
    {
        [Key]
        public int CiudadId { get; set; }
        public string CiudadNombre { get; set; }
    }
}
