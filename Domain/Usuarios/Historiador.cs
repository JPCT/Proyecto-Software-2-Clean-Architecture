using L01_Domain.Common;
using L01_Domain.Multimedias;
using L01_Domain.SitiosHistoricos;
using System;
using System.Collections.Generic;
using System.Text;

namespace L01_Domain.Usuarios
{
    public class Historiador : Usuario
    {
        private List<Multimedia> certificado { get; set; }
        private String descripcionExperiencia { get; set; }
        private bool autorizado { get; set; }
        private List<SitioHistorico> sitiosHistoricos { get; set; }

        public Historiador(string id, string nombre, string apellido, DateTime fechaNacimiento, Multimedia fotoPerfil, TipoSexo tipoSexo, string correoElectronico, string ciudad, string pais, TipoRol rol,List<Multimedia> certificado, string descripcionExperiencia, bool autorizado, List<SitioHistorico> sitiosHistoricos) : 
            base(id, nombre, apellido, fechaNacimiento, fotoPerfil, tipoSexo,correoElectronico, ciudad,  pais, rol)
        {
            this.certificado = certificado;
            this.descripcionExperiencia = descripcionExperiencia;
            this.autorizado = autorizado;
            this.sitiosHistoricos = sitiosHistoricos;
        }

    }
}
