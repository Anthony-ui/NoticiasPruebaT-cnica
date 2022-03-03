using System;
using System.Collections.Generic;

#nullable disable

namespace NoticiasPruebaTécnica.Models
{
    public partial class NoticiasEventos
    {
        public int IdNoticia { get; set; }
        public string Titulo { get; set; }
        public string Noticia { get; set; }
        public string Imagen { get; set; }
        public DateTime? Hora { get; set; }
    }
}
