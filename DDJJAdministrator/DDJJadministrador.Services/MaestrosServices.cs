using DDJJAdministrator.DataStore;
using DDJJAdministrator.Entidades;
namespace DDJJAdministrador.Services
{
    public class MaestrosServices
    {
        DatosMaestros datosMaestros = new DatosMaestros();
        public List<SintomaCovid> ListarSintomas()
        {
            //Logica de valisacion

            return datosMaestros.GetSintomas();
        }
        public List<GruposRiesgos> gruposRiesgos()
        {
            return datosMaestros.GetGrupoRiesgo();
        }
    }
}