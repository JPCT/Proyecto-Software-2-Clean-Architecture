using L01_Domain.Usuarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace L01_Domain.Usuarios
{
    /// <summary>
    /// Esta clase sirve como interfaz con el repositorio
    /// el cual puede ser fake, json o almacenado en base de datos
    /// y eso será indistinguible para el resto de la aplicación
    /// </summary>
    public interface IRepositorioUsuario
    {
        Usuario buscarUsuario(string idUsuario);
        bool actualizarPerfilUsuario(Usuario idUsuario);
    }
}
