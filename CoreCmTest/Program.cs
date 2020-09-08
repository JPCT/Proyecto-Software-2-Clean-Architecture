using L01_Application.RegistrarHistoria;
using L01_Domain.Paciente;
using L02_Persistence;
using L03_FakeDB;
using System;

namespace CoreCmTest
{
    class Program
    {
        static void Main(string[] args)
        {
           

            
            
        }

        /*Test crea historiaa
             Se pasan los datos necesarios a la controladora para que empiece a ejecutar los metodos necesarios para
            agregar la nueva historia*/
        public static void registrarHistoria()
        {
            Ctrl_RegistrarHistoria controlarHistoria = new Ctrl_RegistrarHistoria();
            DateTime fecha = new DateTime(2020, 08, 08);
            controlarHistoria.registrarHistoria("La historia", fecha, "Que lindo dia", null, "15");


            string historias = TablaHistoria.ToJSON();


            Console.WriteLine(historias);
        }
    }
}
