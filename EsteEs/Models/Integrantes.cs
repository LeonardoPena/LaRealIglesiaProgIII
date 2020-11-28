using System;
using System.Collections.Generic;

namespace EsteEs.Models
{
    public partial class Integrantes
    {
        public Integrantes()
        {
            DatosAcademicos = new HashSet<DatosAcademicos>();
            DatosEclesiasticos = new HashSet<DatosEclesiasticos>();
            DatosFamiliares = new HashSet<DatosFamiliares>();
            DatosLaborales = new HashSet<DatosLaborales>();
        }

        public int Id { get; set; }
        public string Sexo { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string CiudadNacimiento { get; set; }
        public string PaisResidencia { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
        public string TipoDocIdentidad { get; set; }
        public string DocIdentidad { get; set; }
        public string PaisNacimiento { get; set; }
        public string CiudadResidencia { get; set; }

        public virtual ICollection<DatosAcademicos> DatosAcademicos { get; set; }
        public virtual ICollection<DatosEclesiasticos> DatosEclesiasticos { get; set; }
        public virtual ICollection<DatosFamiliares> DatosFamiliares { get; set; }
        public virtual ICollection<DatosLaborales> DatosLaborales { get; set; }
    }
}
