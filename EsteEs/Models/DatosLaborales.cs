using System;
using System.Collections.Generic;

namespace EsteEs.Models
{
    public partial class DatosLaborales
    {
        public int Id { get; set; }
        public int IdIntegrante { get; set; }
        public string Profesion { get; set; }
        public string NombreEmpresa { get; set; }
        public string Ocupacion { get; set; }
        public string Telefono { get; set; }

        public virtual Integrantes IdIntegranteNavigation { get; set; }
    }
}
