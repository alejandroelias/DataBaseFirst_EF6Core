using System;
using System.Collections.Generic;

namespace DataBaseFirst_EF6Core.Entidades
{
    /// <summary>
    /// descrpicion de tipo de accion
    /// </summary>
    public partial class Accion
    {
        public Accion()
        {
            Cabeceras = new HashSet<Cabecera>();
            CorreoXAccions = new HashSet<CorreoXAccion>();
        }

        public int Id { get; set; }
        /// <summary>
        /// se representara como el titulo del correo
        /// </summary>
        public string Nombre { get; set; } = null!;

        public virtual ICollection<Cabecera> Cabeceras { get; set; }
        public virtual ICollection<CorreoXAccion> CorreoXAccions { get; set; }
    }
}
