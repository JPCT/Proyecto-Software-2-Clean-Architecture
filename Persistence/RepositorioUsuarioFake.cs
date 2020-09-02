using L01_Domain.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static L03_FakeDB.TablaUsuario;

namespace L02_Persistence
{
    public class RepositorioUsuarioFake:IRepositorioUsuario
    {
        public Usuario buscarUsuario(string idUsuario)
        {
            List<Usuario> usuarios;

            String jsonString = L03_FakeDB.TablaUsuario.ToJSON();
            Console.WriteLine(jsonString);

            /*
             * Prueba de Serialización para un Usuario
             */
            //jsonString = "[{\"id\": \"10009\",\"nombre\": \"NombreUsuario 9\",\"apellido\": \"ApellidosUsuario 9\",\"fechaNacimiento\": \"2020-09-01T21:07:24.7884632-05:00\",\"fotoPerfil\": {\"id\":\"123\",\"nombreArchivo\":\"123\",\"tamano\":\"123\",\"url\":\"123\",\"tipo\":\"123\",\"formato\":\"123\" },\"tipoSexo\": 0,\"correoElectronico\": \"usuario9@historian.com\",\"ciudad\": \"ciudadUsuario 9\",\"pais\": \"paisUsuario 9\",\"rol\": 3}]";
            jsonString = "[{\"id\": \"10009\",\"nombre\": \"NombreUsuario 9\",\"apellido\": \"ApellidosUsuario 9\",\"fechaNacimiento\": null,\"fotoPerfil\": {\"id\":\"123\",\"nombreArchivo\":\"123\",\"tamano\":\"123\",\"url\":\"123\",\"tipo\":\"123\",\"formato\":\"123\" },\"tipoSexo\": 0,\"correoElectronico\": \"usuario9@historian.com\",\"ciudad\": \"ciudadUsuario 9\",\"pais\": \"paisUsuario 9\",\"rol\": 3}]";
            Console.WriteLine(jsonString);

            usuarios = System.Text.Json.JsonSerializer.Deserialize<List<Usuario>>(jsonString);

            Usuario usuario = usuarios.FirstOrDefault(u => u.id == idUsuario);

            if (usuario is null)
            {
                throw new UsuarioException("El Usuario con Id-->" + idUsuario + ", no esta registrado");
            }
            return usuario;
        }
        public bool actualizarPerfilUsuario(Usuario usuario)
        {
            try
            {
                List<AtributosUsuario> usuarios;
                usuarios = L03_FakeDB.TablaUsuario.getTablaUsuarios();

                for(int i = 0; i < usuarios.Count; i++)
                {
                    if(usuarios[i].id == usuario.id)
                    {
                        usuarios[i].nombre = usuario.nombre;
                        usuarios[i].apellido = usuario.apellido;
                        usuarios[i].fotoPerfil = usuario.fotoPerfil;
                        usuarios[i].tipoSexo = usuario.tipoSexo;
                        usuarios[i].correoElectronico = usuario.correoElectronico;
                        usuarios[i].ciudad = usuario.ciudad;
                        usuarios[i].pais = usuario.pais;
                    }
                }
            }
            catch
            {
                throw new ActualizarUsuarioException("Hubo un error al actualizar el perfil");
            }
            return true;
        }
    }
}
