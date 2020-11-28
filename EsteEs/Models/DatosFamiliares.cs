using System;
using System.Collections.Generic;

namespace EsteEs.Models
{
    public partial class DatosFamiliares
    {
        public int Id { get; set; }
        public int IdIntegrante { get; set; }
        public string EstadoCivil { get; set; }
        public string Hijos { get; set; }

        public virtual Integrantes IdIntegranteNavigation { get; set; }
    }
}
