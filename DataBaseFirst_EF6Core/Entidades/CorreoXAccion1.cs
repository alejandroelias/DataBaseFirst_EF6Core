using System;
using System.Collections.Generic;

namespace DataBaseFirst_EF6Core.Entidades
{
    public partial class CorreoXAccion1
    {
        public string Correo { get; set; } = null!;
        public int Accion { get; set; }
        public string Titulo { get; set; } = null!;
    }
}
