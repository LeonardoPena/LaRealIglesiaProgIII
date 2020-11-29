using System;
using System.Collections.Generic;

namespace EsteEs.Models
{
    public partial class DatosEclesiasticos
    {
        public int Id { get; set; }
        public int IdIntegrante { get; set; }

        public DateTime? FechaConversion { get; set; }
        public DateTime? FechaBautismo { get; set; }
        public DateTime? FechaAceptado { get; set; }
        public string Denominacion { get; set; }
        public string NombreIglesia { get; set; }
        public string CongregacionAnterior { get; set; }
        public string Pastor { get; set; }
        public string Disciplinado { get; set; }
        public decimal? DisciplinadoVeces { get; set; }
        public string DisciplinadoCausas { get; set; }
        public string Funciones { get; set; }
        public string Ministerios { get; set; }
        public string MinisteriosMayorFruto { get; set; }
        public string MinisteriosLlamado { get; set; }
        public string Metas { get; set; }
        public string Respaldo { get; set; }

        public virtual Integrantes IdIntegranteNavigation { get; set; }
    }
}
