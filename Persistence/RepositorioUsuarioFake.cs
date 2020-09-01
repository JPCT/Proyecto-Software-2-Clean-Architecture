using L01_Domain.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L02_Persistence
{
    public class RepositorioUsuarioFake:IRepositorioUsuario
    {
        public Usuario buscarUsuario(string idUsuario)
        {
            List<Usuario> usuarios;

            String jsonString = L03_FakeDB.TablaUsuario.ToJSON();
            usuarios = System.Text.Json.JsonSerializer.Deserialize<List<Usuario>>(jsonString);

            Usuario usuario = usuarios.FirstOrDefault(u => u.id == idUsuario);

            if (usuario is null)
            {
                throw new UsuarioException("El Usuario con Id-->" + idUsuario + ", no esta registrado");
            }
            return usuario;
        }
    }
}
