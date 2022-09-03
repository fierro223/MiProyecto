using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDJJAdministrator.DataStore;
using DDJJAdministrator.Entidades;

namespace DDJJAdministrator.Services
{
    public class MaestroService
    {
        DatosMaestros datosMaestros = new DatosMaestros();
        public List<SintomaCovid> ListarSintomas()
        {
            //Logica de valisacion

            return datosMaestros.GetSintomas();
        }
        /*public List<GruposRiesgos> gruposRiesgos()
        {
            return datosMaestros.GetGrupoRiesgo();
        }*/
        public List<CodigoPais> codigoPais()
        {
            return datosMaestros.CodigoPais();
        }
        public List<Nacional> Nacional()
        {
            return datosMaestros.Nacional();
        }
        public List<Residencia> Residencia()
        {
            return datosMaestros.Residencia();
        }
        public List<Departamentos> Departamentos()
        {
            return datosMaestros.Departamentos();
        }

    }
}
