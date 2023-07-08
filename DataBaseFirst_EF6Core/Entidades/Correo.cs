﻿using System;
using System.Collections.Generic;

namespace DataBaseFirst_EF6Core.Entidades
{
    /// <summary>
    /// correos a los que se les enviara distintas acciones al momento de realizar alguna tarea en los aplicativos
    /// </summary>
    public partial class Correo
    {
        public Correo()
        {
            CorreoXAccions = new HashSet<CorreoXAccion>();
        }

        public int Id { get; set; }
        public string Valor { get; set; } = null!;

        public virtual ICollection<CorreoXAccion> CorreoXAccions { get; set; }
    }
}
