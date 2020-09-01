using L01_Application.Autenticacion;
using L01_Domain.Common;
using L01_Domain.Multimedias;
using L01_Domain.Usuarios;
using L02_Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace L01_Application.GestionarPerfil
{
    class Ctrl_GestionarPerfil
    {
        public bool actualizarPerfil(string id,string nombre,string apellido,DateTime fechaNac,Multimedia fotoPerfil,
                                    TipoSexo tipoSexo,string correoElectronico,string ciudad,string pais)
        {
            Usuario usuario = buscarUsuario(id);
            //Quede en este punto, aquí debo seguir con la actualización correspondiente del usuario
            return true;
        }
        public Usuario buscarUsuario(string idUsuario)
        {
            try
            {
                if (idUsuario is null)
                    return null;
                IRepositorioUsuario repoU = FabricaRepositoriosUsuarios.CrearRepositorioPacientes();
                Usuario usuario = repoU.buscarUsuario(idUsuario);
                return usuario;
            }
            catch (UsuarioException ex)
            {
                throw ex;
            }
        }
    }
}
