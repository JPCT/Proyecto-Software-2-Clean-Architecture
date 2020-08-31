using System;
using System.Collections.Generic;
using System.Text;

namespace L01_Domain.SitiosHistoricos
{
    public class Posicion
    {
        private string id { get; set; }
        private float latitud { get; set; }
        private float longitud { get; set; }
        private string direccion { get; set; }

        public Posicion(string id, float latitud, float longitud, string direccion)
        {
            this.id = id;
            this.latitud = latitud;
            this.longitud = longitud;
            this.direccion = direccion;
        }
    }
}
