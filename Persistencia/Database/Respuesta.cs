//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Persistencia.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Respuesta
    {
        public int Id { get; set; }
        public string Mensaje { get; set; }
        public bool Correcta { get; set; }
        public long VecesSeleccionada { get; set; }
        public int PreguntaId { get; set; }
    
        public virtual Pregunta Pregunta { get; set; }
    }
}
