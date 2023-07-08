using System;
using System.Collections.Generic;

namespace DataBaseFirst_EF6Core.Entidades
{
    public partial class Color
    {
        public Color()
        {
            Estados = new HashSet<Estado>();
            Registros = new HashSet<Registro>();
        }

        public int Id { get; set; }
        public bool Blanco { get; set; }
        public string Valor { get; set; } = null!;

        public virtual ICollection<Estado> Estados { get; set; }
        public virtual ICollection<Registro> Registros { get; set; }
    }
}
