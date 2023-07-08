using System;
using System.Collections.Generic;

namespace DataBaseFirst_EF6Core.Entidades
{
    public partial class Municipio
    {
        public int Id { get; set; }
        public string Codigo { get; set; } = null!;
        public string Valores { get; set; } = null!;
        public int? IdDepartamento { get; set; }

        public virtual Departamento? IdDepartamentoNavigation { get; set; }
    }
}
