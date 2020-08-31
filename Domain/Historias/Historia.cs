using L01_Domain.Multimedias;
using L01_Domain.Usuarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace L01_Domain.Historias
{
    /// <summary>
    /// Mi primera clase de historia :)
    /// </summary>
    public class Historia
    {

        private string id { get; set; }
        private string titulo { get; set; }
        private DateTime fecha { get; set; }
        private string descripcion { get; set; }
        private List<Multimedia> fotos { get; set; }
        private Usuario contador { get; set; }

        public Historia(string id, string titulo, DateTime fecha, string descripcion, List<Multimedia> fotos, Usuario contador)
        {
            this.id = id;
            this.titulo = titulo;
            this.fecha = fecha;
            this.descripcion = descripcion;
            this.fotos = fotos;
            this.contador = contador;
        }
    }
}
