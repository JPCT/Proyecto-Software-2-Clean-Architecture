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
        public void actualizarPerfil(string nombre,string apellido,DateTime fechaNac,Multimedia fotoPerfil,
                                    TipoSexo tipoSexo,string correoElectronico,string ciudad,string pais)
        {
            try
            {
                Usuario usuario = RepositorioUsuarioFake.GetUsuario(int.Parse(idPaciente));
                return System.Text.Json.JsonSerializer.Serialize(paciente);
            }
            catch (UsuarioException ex)
            {
                throw ex;
            }
        }
    }
}
