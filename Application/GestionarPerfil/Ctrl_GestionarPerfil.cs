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
    public class Ctrl_GestionarPerfil
    {
        /// <summary>
        /// Este método es llamado desde la controladora o desde el formulario 
        /// de la aplicación, se encarga de buscar el usuario a modificar
        /// y le realiza las modificaciones correspondientes, para después 
        /// implementar este cambio en el repositorio
        /// </summary>
        /// <param name="id">id del usuario a modificar</param>
        /// <param name="nombre">nombre del usuario a modificar</param>
        /// <param name="apellido">apellido del usuario a modificar</param>
        /// <param name="fechaNac">fecha de nacimiento del usuario a modificar</param>
        /// <param name="fotoPerfil">fotoPerfil del usuario a modificar</param>
        /// <param name="tipoSexo">Sexo del usuario a modificar</param>
        /// <param name="correoElectronico">correo del usuario a modificar</param>
        /// <param name="ciudad">ciudad del usuario a modificar</param>
        /// <param name="pais">pais del usuario a modificar</param>
        /// <returns>Retorna un booleano que indica si la actualización es correcta</returns>
        public bool actualizarPerfil(string id,string nombre,string apellido,DateTime fechaNac,Multimedia fotoPerfil,
                                    TipoSexo tipoSexo,string correoElectronico,string ciudad,string pais)
        {
            Usuario usuario = buscarUsuario(id);

            usuario.nombre = (nombre != null) ? nombre : usuario.nombre;
            usuario.apellido = (apellido != null) ? apellido : usuario.apellido;
            usuario.fechaNacimiento = (fechaNac != null) ? fechaNac : usuario.fechaNacimiento;
            usuario.fotoPerfil = (fotoPerfil != null) ? fotoPerfil : usuario.fotoPerfil;
            usuario.tipoSexo = (tipoSexo != null) ? tipoSexo : usuario.tipoSexo;
            usuario.correoElectronico = (correoElectronico != null) ? correoElectronico : usuario.correoElectronico;
            usuario.ciudad = (ciudad != null) ? ciudad : usuario.ciudad;
            usuario.pais = (pais != null) ? pais : usuario.pais;

            try
            {
                IRepositorioUsuario repoU = FabricaRepositoriosUsuarios.CrearRepositorioPacientes();
                repoU.actualizarPerfilUsuario(usuario);
            }
            catch(ActualizarUsuarioException ex)
            {
                throw ex;
            }
            return true;
        }

        /// <summary>
        /// A partir de un id, busca en el repositorio de usuarios y retorna un objeto 
        /// Usuario con el id que coincide.
        /// </summary>
        /// <param name="idUsuario">id del usuario a buscar</param>
        /// <returns>Devuelve un objeto Usuario que correponde al id entrante</returns>
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
