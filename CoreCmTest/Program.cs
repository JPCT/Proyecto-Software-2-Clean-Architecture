using L01_Domain.Paciente;
using L01_Application.GestionarPerfil;
using L02_Persistence;
using System;
using L01_Domain.Usuarios;
using L03_FakeDB;
using L01_Application.RegistrarSitio;
using L01_Domain.SitiosHistoricos;
using System.Globalization;

namespace CoreCmTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generacion de nuevos sitios y de la tabla
            TablaSitioHistorico.InstanciarSitios(3);
            string sitios = TablaSitioHistorico.ToJSON();
            Console.WriteLine(sitios);

            //// Tests de verificar sitio historico
            //try
            //{
            //    Console.WriteLine("Ingrese el nombre del sitio a buscar: ");
            //    string nombreSitio = Console.ReadLine();
            //    Console.WriteLine("Ingrese la latitud: ");
            //    string latitud = Console.ReadLine();
            //    Console.WriteLine("Ingrese la longitud: ");
            //    string longitud = Console.ReadLine();
            //    Posicion posicion = new Posicion(Guid.NewGuid().ToString(), float.Parse(latitud, CultureInfo.InvariantCulture.NumberFormat), float.Parse(longitud, CultureInfo.InvariantCulture.NumberFormat), "Direccion");
            //    bool encontrado = new Ctrl_RegistrarSitio().verificarSitioExistente(nombreSitio, posicion);
            //    Console.WriteLine(encontrado);
            //}
            //catch (SitioExistenteException ex)
            //{
            //    Console.WriteLine("ERROR-->" + ex.Message);
            //}
            
            // Tests de crear nuevo sitio historicos
            try
            {
                bool registrado = new Ctrl_RegistrarSitio().registrarSitio("Nombre", "Descripcion", null, "idHistoriador");
                Console.WriteLine(registrado);
                sitios = TablaSitioHistorico.ToJSON();
                Console.WriteLine(sitios);
            }
            catch (SitioExistenteException ex)
            {
                Console.WriteLine("ERROR-->" + ex.Message);
            }

            Console.ReadLine();
        }
    }
}
