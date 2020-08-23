using L01_Domain.Paciente;
using L02_Persistence;
using System;

namespace CoreCmTest
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Test the JSON generetion */
            // FakeDB.TablaPacientes.InstanciarPacientes(10);
            // String s = FakeDB.TablaPacientes.ToJSON();
            //Console.WriteLine(s);

            /* Test Persistence */
            try
            {

                IPacienteCita p = RepositorioPacientes.GetPaciente(10008);

                Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(p));

            }
            catch(PacienteNoEncontradoException ex)
            {
                Console.WriteLine("ERROR-->"+ex.Message);
            }
            


           

            Console.ReadLine();
        }
    }
}
