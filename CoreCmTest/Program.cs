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
            L03_FakeDB.TablaUsuario.InstanciarUsuarios(20);
            String s = L03_FakeDB.TablaUsuario.ToJSON();
            Console.WriteLine(s);

            /* Test Controladora para buscar Usuario */
            try
            {
                Console.WriteLine("Indique el id del usuario a buscar: ");
                String idUsuario = Console.ReadLine();
                Ctrl_GestionarPerfil controlGestionar = new Ctrl_GestionarPerfil();
                Usuario usuario = controlGestionar.buscarUsuario(idUsuario);
                Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(usuario));

            }
            catch(UsuarioException ex)
            {
                Console.WriteLine("ERROR-->"+ex.Message);
            }

            /* Test Controladora para actualizar Usuario */
            try
            {
                Console.WriteLine("Indique el id del usuario a actualizar: ");
                String idUsuario = Console.ReadLine();
                Ctrl_GestionarPerfil controlGestionar = new Ctrl_GestionarPerfil();

                //Aquí obtengo el valor anterior
                Usuario usuario = controlGestionar.buscarUsuario(idUsuario);
                Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(usuario));

                //Realizar la actualizacion
                bool confirmacion = controlGestionar.actualizarPerfil(idUsuario,"edit", "edit", usuario.fechaNacimiento, null, 0, "edit", "edit", "edit");

                //Verificar actualizacion
                Usuario usu = controlGestionar.buscarUsuario(idUsuario);
                Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(usu));
            }
            catch (UsuarioException ex)
            {
                Console.WriteLine("ERROR-->" + ex.Message);
            }




            Console.ReadLine();
        }
    }
}
