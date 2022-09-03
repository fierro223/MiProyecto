using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDJJAdministrator.Entidades;

namespace DDJJAdministrator.DataStore
{
    public class DbOperations
    {
        private string ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; 
                                            AttachDbFilename = C:\Users\emili\Downloads\DDJJAdministrator\DDJJAdminostrator.DataStore\DataBase\DDJJOB.mdf; Integrated Security = True";
        //Metodo que prosesa los query SELET
        //Podemos obtener 1 o muchos resultados
        public List<T> OpetationQuery<T>(string SqlQuery )
        {
            List<T> lstResult;

            using (var connection = new SqlConnection(ConnectionString))
            {

                lstResult = connection.Query<T>(SqlQuery).ToList();


            }
            return lstResult;

        }
        public void Operationexecute(DeclaracionJurada declaracionJurada)
        {
            string sql = "INSERT INTO DeclaracionJurada (IdPersona, FechaIngreso, IdStatus, FechaCreacion, GrupoDeRiesgo, Vacunacion, Viajes, PersonaExterior, ContactoExterior, CasosSopechosos, PresentaSintoma) Values (@IdPersona, @FechaIngreso, @IdStatus, @FechaCreacion, @GrupoDeRiesgo, @Vacunacion, @Viajes, @PersonaExterior, @ContactoExterior, @CasosSopechosos, @PresentaSintoma);";

            using (var connection = new SqlConnection(ConnectionString))
            {
                var affectedRows = connection.Execute(sql, new { IdPersona = 1, FechaIngreso=declaracionJurada.datosPersonales.FechaDeIngreso,
                    IdStatus=1, FechaCreacion=DateTime.Now, GrupoDeRiesgo= declaracionJurada.datosPersonales.GrupoRiesgo, 
                    Vacunacion=declaracionJurada.datosPersonales.Vacunas, Viajes=declaracionJurada.datosPersonales.Viajes, 
                    PersonaExterior=declaracionJurada.contatoCovid.PersonaExterior, ContactoExterior=declaracionJurada.contatoCovid.ContactoExtrecho, 
                    CasosSopechosos=declaracionJurada.contatoCovid.CasoSopechoso, PresentaSintoma=declaracionJurada.contatoCovid.PresentaSintoma });
                //Profe Trabajar el IdPersona
                //Console.WriteLine(affectedRows);

                //var customer = connection.Query<Customer>("Select * FROM CUSTOMERS WHERE CustomerName = 'Mark'").ToList();

                //FiddleHelper.WriteTable(customer);
            }

        }


    }
}
