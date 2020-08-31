using L01_Domain.Common;
using L01_Domain.Multimedias;
using System;
using System.Collections.Generic;
using System.Text;

namespace L01_Domain.Usuarios
{
    public class Usuario
    {
        private string id { get; set; }
        private string nombre { get; set; }
        private string apellido { get; set; }
        private DateTime fechaNacimiento { get; set; }
        private Multimedia fotoPerfil { get; set; }
        private TipoSexo tipoSexo { get; set; }
        private string correoElectronico { get; set; }
        private string ciudad { get; set; }
        private string pais { get; set; }
        private TipoRol rol { get; set; }

        public Usuario(string id, string nombre, string apellido, DateTime fechaNacimiento, Multimedia fotoPerfil, TipoSexo tipoSexo, string correoElectronico, string ciudad, string pais, TipoRol rol)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.fotoPerfil = fotoPerfil;
            this.tipoSexo = tipoSexo;
            this.correoElectronico = correoElectronico;
            this.ciudad = ciudad;
            this.pais = pais;
            this.rol = rol;
        }
    }
}
