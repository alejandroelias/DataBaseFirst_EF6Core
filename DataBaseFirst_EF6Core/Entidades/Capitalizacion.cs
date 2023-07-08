using System;
using System.Collections.Generic;

namespace DataBaseFirst_EF6Core.Entidades
{
    public partial class Capitalizacion
    {
        public Capitalizacion()
        {
            Pdfs = new HashSet<Pdf>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Ejemplo { get; set; } = null!;

        public virtual ICollection<Pdf> Pdfs { get; set; }
    }
}
