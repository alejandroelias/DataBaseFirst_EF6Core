using System;
using System.Collections.Generic;

namespace DataBaseFirst_EF6Core.Entidades
{
    public partial class PdfVinculacion
    {
        public PdfVinculacion()
        {
            PdfSeccions = new HashSet<PdfSeccion>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<PdfSeccion> PdfSeccions { get; set; }
    }
}
