using L01_Domain.Paciente;
using L01_Application.GestionarPerfil;
using L02_Persistence;
using System;
using L01_Domain.Usuarios;

namespace CoreCmTest
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Test the JSON generetion */
            L03_FakeDB.TablaUsuario.InstanciarUsuarios(10);
            String s = L03_FakeDB.TablaUsuario.ToJSON();
            Console.WriteLine(s);

            /* Test Controladora para buscar Usuario */
            try
            {
                Console.WriteLine("Indique el id del usuario a buscar: ");
                String idUsuario = Console.ReadLine();
                Ctrl_GestionarPerfil controlGestionar = new Ctrl_GestionarPerfil();
                Usuario usuario = controlGestionar.buscarUsuario(idUsuario);
                Console.WriteLine("ESTO ES: "+ System.Text.Json.JsonSerializer.Serialize(usuario));

            }
            catch(UsuarioException ex)
            {
                Console.WriteLine("ERROR-->"+ex.Message);
            }




            Console.ReadLine();
        }
    }
}
