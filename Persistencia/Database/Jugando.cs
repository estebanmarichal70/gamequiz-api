
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
    
public partial class Jugando
{

    public int Id { get; set; }

    public int JuegoId { get; set; }



    public virtual Usuario Usuario { get; set; }

    public virtual Juego Juego { get; set; }

}

}
