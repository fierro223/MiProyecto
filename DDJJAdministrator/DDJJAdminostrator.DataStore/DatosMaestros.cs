using Dapper;
using DDJJAdministrator.Entidades;
using System.Data.SqlClient;

namespace DDJJAdministrator.DataStore

{
    public class DatosMaestros
    {
        DbOperations dbOperations = new DbOperations();
        public List<SintomaCovid> GetSintomas()
        {
            

            List<SintomaCovid> LstSintomas = new List<SintomaCovid>();

            string sql = "SELECT IdSintoma, NombreSintoma FROM SintomaCovid";

            LstSintomas = dbOperations.OpetationQuery<SintomaCovid>(sql);

 

            //LstSintomas.Add(new SintomaCovid() { IdSintoma = 1, NombreSintoma = "Fiebre" });

            //LstSintomas.Add(new SintomaCovid() { IdSintoma = 2, NombreSintoma = "Tos" });

            //LstSintomas.Add(new SintomaCovid() { IdSintoma = 3, NombreSintoma = "Dolor de cabeza" });

            //LstSintomas.Add(new SintomaCovid() { IdSintoma = 4, NombreSintoma = "Alteracion del olfato y gusto" });

            //LstSintomas.Add(new SintomaCovid() { IdSintoma = 5, NombreSintoma = "Cefaleo" });

            //LstSintomas.Add(new SintomaCovid() { IdSintoma = 6, NombreSintoma = "Mialgia" });

            //LstSintomas.Add(new SintomaCovid() { IdSintoma = 7, NombreSintoma = "Bomito o diarea" });

            //LstSintomas.Add(new SintomaCovid() { IdSintoma = 8, NombreSintoma = "Congestion nasal" });

            return LstSintomas;
        }
        public List<CodigoPais> CodigoPais()
        {
            List<CodigoPais> comCodigoPais = new List<CodigoPais>();

            
            string sql = "SELECT IdCodigoPais, NombreCodigoPais FROM CodigoPais";

            using (var connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\emili\Downloads\DDJJAdministrator\DDJJAdminostrator.DataStore\DataBase\DDJJOB.mdf; Integrated Security = True"))
            {
               
                comCodigoPais = connection.Query<CodigoPais>(sql).ToList();

                comCodigoPais.Insert(0, new CodigoPais() { IdCodigoPais = 0, NombreCodigoPais = "Codigo Pais" });
            }

            //comCodigoPais.Add(new CodigoPais() { IdCodigoPais = 0, NombreCodigoPais = "Codigo Pais" });

            //comCodigoPais.Add(new CodigoPais() { IdCodigoPais = 1, NombreCodigoPais = "Argentina(+54)" });

            //comCodigoPais.Add(new CodigoPais() { IdCodigoPais = 2, NombreCodigoPais = "Bolivia(+591)" });

            //comCodigoPais.Add(new CodigoPais() { IdCodigoPais = 3, NombreCodigoPais = "Brasil(+55)" });

            //comCodigoPais.Add(new CodigoPais() { IdCodigoPais = 4, NombreCodigoPais = "Chile(+56)" });

            //comCodigoPais.Add(new CodigoPais() { IdCodigoPais = 5, NombreCodigoPais = "Colombia(+57)" });

            //comCodigoPais.Add(new CodigoPais() { IdCodigoPais = 6, NombreCodigoPais = "Ecuador(+593)" });

            //comCodigoPais.Add(new CodigoPais() { IdCodigoPais = 7, NombreCodigoPais = "Paraguay(+595)" });

            //comCodigoPais.Add(new CodigoPais() { IdCodigoPais = 8, NombreCodigoPais = "Peru(+51)" });

            //comCodigoPais.Add(new CodigoPais() { IdCodigoPais = 9, NombreCodigoPais = "Uruguay(+598)" });

            //comCodigoPais.Add(new CodigoPais() { IdCodigoPais = 10, NombreCodigoPais = "Venesuela(+58)" });

            return comCodigoPais;
        }
        public List<Nacional> Nacional()
        {
            List<Nacional> comNacional = new List<Nacional>();
            string sql = "SELECT IdNacional, NombreNacional FROM Nacional";

            using (var connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\emili\Downloads\DDJJAdministrator\DDJJAdminostrator.DataStore\DataBase\DDJJOB.mdf; Integrated Security = True"))
            {

                comNacional = connection.Query<Nacional>(sql).ToList();

                comNacional.Insert(0, new Nacional() { IdNacional = 0, NombreNacional = "Nacionalidad" });
            }

            //comNacional.Add(new Nacional() { IdNacional = 0, NombreNacional = "Nacionalidad" });

            //comNacional.Add(new Nacional() { IdNacional = 1, NombreNacional = "Argentina" });

            //comNacional.Add(new Nacional() { IdNacional = 2, NombreNacional = "Bolivia" });

            //comNacional.Add(new Nacional() { IdNacional = 3, NombreNacional = "Brasil" });

            //comNacional.Add(new Nacional() { IdNacional = 4, NombreNacional = "Chile" });

            //comNacional.Add(new Nacional() { IdNacional = 5, NombreNacional = "Colombia" });

            //comNacional.Add(new Nacional() { IdNacional = 6, NombreNacional = "Ecuador" });

            //comNacional.Add(new Nacional() { IdNacional = 7, NombreNacional = "Paraguay" });

            //comNacional.Add(new Nacional() { IdNacional = 8, NombreNacional = "Peru" });

            //comNacional.Add(new Nacional() { IdNacional = 9, NombreNacional = "Usuguay" });

            //comNacional.Add(new Nacional() { IdNacional = 10, NombreNacional = "Venesuela" });


            return comNacional;
        }
        public List<Residencia> Residencia()
        {
            List<Residencia> comResidencia = new List<Residencia>();

            comResidencia.Add(new Residencia() { IdResidencia = 0, NombreResidencia = "Pais de Residencia" });

            comResidencia.Add(new Residencia() { IdResidencia = 1, NombreResidencia = "Argentina" });

            comResidencia.Add(new Residencia() { IdResidencia = 2, NombreResidencia = "Bolivia" });

            comResidencia.Add(new Residencia() { IdResidencia = 3, NombreResidencia = "Brasil" });

            comResidencia.Add(new Residencia() { IdResidencia = 4, NombreResidencia = "Chile" });

            comResidencia.Add(new Residencia() { IdResidencia = 5, NombreResidencia = "Colombia" });

            comResidencia.Add(new Residencia() { IdResidencia = 6, NombreResidencia = "Ecuador" });

            comResidencia.Add(new Residencia() { IdResidencia = 7, NombreResidencia = "Paraguay" });

            comResidencia.Add(new Residencia() { IdResidencia = 8, NombreResidencia = "Peru" });

            comResidencia.Add(new Residencia() { IdResidencia = 9, NombreResidencia = "Usuguay" });

            comResidencia.Add(new Residencia() { IdResidencia = 10,NombreResidencia = "Venesuela" });


            return comResidencia;
        }
        public List<Departamentos> Departamentos()
        {
            List<Departamentos> comDepartamentos = new List<Departamentos>();

            comDepartamentos.Add(new Departamentos() { IdDepartamentos = 0, NombreDepartamentos = "Departamentos de la Empresa" });

            comDepartamentos.Add(new Departamentos() { IdDepartamentos = 1, NombreDepartamentos = "Adminstracion" });

            comDepartamentos.Add(new Departamentos() { IdDepartamentos = 2, NombreDepartamentos = "Compras" });

            comDepartamentos.Add(new Departamentos() { IdDepartamentos = 3, NombreDepartamentos = "Deposito" });

            comDepartamentos.Add(new Departamentos() { IdDepartamentos = 4, NombreDepartamentos = "RRHH" });

            comDepartamentos.Add(new Departamentos() { IdDepartamentos = 5, NombreDepartamentos = "Ventas" });


            return comDepartamentos;
        }

    }


}
