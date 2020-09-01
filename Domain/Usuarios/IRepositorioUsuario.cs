using L01_Domain.Usuarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace L01_Domain.Usuarios
{
    public interface IRepositorioUsuario
    {
        Usuario GetUsuario(string idUsuario);
    }
}
