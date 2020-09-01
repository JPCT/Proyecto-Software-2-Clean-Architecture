using L01_Domain.Usuarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace L02_Persistence
{
    public class FabricaRepositoriosUsuarios
    {
        public static IRepositorioUsuario CrearRepositorioPacientes()
        {
            //var repo = ConfigurationManager.AppSettings["repositoryUsuarios"];
            var repo = "fake";

            return repo switch
            {
                "fake" => new RepositorioUsuarioFake()
                _ => null,
            };
        }
    }
}
