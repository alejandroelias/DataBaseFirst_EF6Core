﻿using System;
using System.Collections.Generic;

namespace DataBaseFirst_EF6Core.Entidades
{
    public partial class TipoDocumentoContingencium
    {
        public int Id { get; set; }
        public string Codigo { get; set; } = null!;
        public string Valores { get; set; } = null!;
    }
}
