using L01_Domain.Historias;
using L01_Domain.Multimedias;
using System;
using System.Collections.Generic;
using System.Text;

namespace L01_Domain.SitiosHistoricos
{
    public class SitioHistorico
    {
        private string id { get; set; }
        private string nombre { get; set; }
        private string descripcion { get; set; }
        private List<Multimedia> contenidoMultimedia { get; set; }
        private float validez { get; set; }
        private List<Historia> historias { get; set; }
        private Posicion posicion { get; set; }

        public SitioHistorico(string id, string nombre, string descripcion, List<Multimedia> contenidoMultimedia, float validez, List<Historia> historias, Posicion posicion)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.contenidoMultimedia = contenidoMultimedia;
            this.validez = validez;
            this.historias = historias;
            this.posicion = posicion;
        }
    }
}
