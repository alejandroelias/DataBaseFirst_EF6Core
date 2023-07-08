using System;
using System.Collections.Generic;

namespace DataBaseFirst_EF6Core.Entidades
{
    public partial class TipoDocumento
    {
        public TipoDocumento()
        {
            Jsons = new HashSet<Json>();
            ValorDefectos = new HashSet<ValorDefecto>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string? Alias { get; set; }

        public virtual ICollection<Json> Jsons { get; set; }
        public virtual ICollection<ValorDefecto> ValorDefectos { get; set; }
    }
}
