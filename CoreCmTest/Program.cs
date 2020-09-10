using L01_Domain.Paciente;
using L01_Application.GestionarPerfil;
using L02_Persistence;
using System;
using L01_Domain.Usuarios;
using L03_FakeDB;
using L01_Application.RegistrarSitio;
using L01_Domain.SitiosHistoricos;
using System.Globalization;
using L01_Application.Autenticacion;

namespace CoreCmTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Autenticar();

        }

        public static void Autenticar()
        {
            Ctrl_Autenticacion controlAutenticar = new Ctrl_Autenticacion();

            try
            {
                Console.WriteLine("Ingrese el AccessToken proporcionado por Google: ");
                String accessToken = Console.ReadLine();
                bool registrado = controlAutenticar.autenticarUsuario(accessToken);

                if (registrado)
                {
                    Console.WriteLine("\n" + "El usuario se a autenticado con exitos" + "\n");
                }
                else
                {
                    Console.WriteLine("\n" + "El usuario no esta registrado" + "\n");
                }

            }
            catch (TokenInvalidoException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Ingrese el AccessToken proporcionado por Google: ");
            String accessToken2 = Console.ReadLine();

            Console.WriteLine("Ingrese su nombre ");
            String nombre = Console.ReadLine();


            Console.WriteLine("Ingrese su apellido ");
            String apellido = Console.ReadLine();

            Console.WriteLine("Ingrese su ciudad de origen : ");
            String ciudad = Console.ReadLine();


            var options = new System.Text.Json.JsonSerializerOptions
            {
                WriteIndented = true
            };

            // Prueba crear un usuario normal
            try
            {

                controlAutenticar.registrarDatosUsuario(accessToken2, nombre, apellido, DateTime.Now, null, L01_Domain.Common.TipoSexo.Hombre, ciudad, null, L01_Domain.Common.TipoRol.Usuario);
                Console.WriteLine("Se han registrado sus datos con exito");
                Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(controlAutenticar.getUsuarios(), options));

            }
            catch (UsuarioException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}
