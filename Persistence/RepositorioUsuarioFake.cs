using L01_Domain.Usuarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace L02_Persistence
{
    public class RepositorioUsuarioFake:IRepositorioUsuario
    {
        public Usuario GetUsuario(string idUsuario)
        {
            List<Usuario> usuarios;

            String jsonString = L03_FakeDB.TablaUsuario.ToJson();
            usuarios = System.Text.Json.JsonSerializer.Deserialize<List<Usuario>>(jsonString);

            Usuario usuario = usuarios.FirstOrDefault(p => p.DocumentoId == idPaciente);
            return usuario;
        }
    }
}
