using System;
using System.Collections.Generic;
using System.Text;

namespace L01_Domain.Multimedias
{
    public class Multimedia
    {

		private string id { get; set; }
		private string nombreArchivo { get; set; }
		private string tamano { get; set; }
		private string url { get; set; }
		private string tipo { get; set; }
		private string formato { get; set; }


        public Multimedia(string id, string nombreArchivo, string tamano, string url, string tipo, string formato)
        {
            this.id = id;
            this.nombreArchivo = nombreArchivo;
            this.tamano = tamano;
            this.url = url;
            this.tipo = tipo;
            this.formato = formato;
        }
        public Multimedia()
        {

        }
    }
}
