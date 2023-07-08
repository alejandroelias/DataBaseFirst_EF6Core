using System;
using System.Collections.Generic;

namespace DataBaseFirst_EF6Core.Entidades
{
    public partial class Tipado
    {
        public Tipado()
        {
            PdfSeccions = new HashSet<PdfSeccion>();
            Pdfs = new HashSet<Pdf>();
            ValorDefectos = new HashSet<ValorDefecto>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<PdfSeccion> PdfSeccions { get; set; }
        public virtual ICollection<Pdf> Pdfs { get; set; }
        public virtual ICollection<ValorDefecto> ValorDefectos { get; set; }
    }
}
