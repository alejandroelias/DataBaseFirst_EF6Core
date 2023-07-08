﻿using System;
using System.Collections.Generic;

namespace DataBaseFirst_EF6Core.Entidades
{
    /// <summary>
    /// Representacion de un termino mas general para los diferentes tipos de estado que se puedenrepresentar en la base de datos
    /// </summary>
    public partial class TipoEstado
    {
        public TipoEstado()
        {
            Estados = new HashSet<Estado>();
        }

        /// <summary>
        /// identity
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// nombre de estado general
        /// </summary>
        public string Nombre { get; set; } = null!;
        /// <summary>
        /// booleano si la respuesta pertenece a hacienda o si simplemente es un estatus http
        /// </summary>
        public bool Hacienda { get; set; }

        public virtual ICollection<Estado> Estados { get; set; }
    }
}
