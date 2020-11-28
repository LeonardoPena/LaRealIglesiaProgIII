using System;
using System.Collections.Generic;

namespace EsteEs.Models
{
    public partial class DatosAcademicos
    {
        public int Id { get; set; }
        public int? IdIntegrante { get; set; }
        public string NivelEstudio { get; set; }
        public string Expulsado { get; set; }

        public virtual Integrantes IdIntegranteNavigation { get; set; }
    }
}
