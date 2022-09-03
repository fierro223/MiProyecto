using DDJJAdministrator.Entidades;
namespace DDJJAdministrator.DataStore
{
    public class DatosMaestros
    {
        public List<SintomaCovid> GetSintomas()
        {
            List<SintomaCovid> Lstsintomas = new List<SintomaCovid>();

            Lstsintomas.Add(new SintomaCovid() { IdSintoma = 1, NombreSintoma = "Fiebre" });

            Lstsintomas.Add(new SintomaCovid() { IdSintoma = 2, NombreSintoma = "Tos" });

            Lstsintomas.Add(new SintomaCovid() { IdSintoma = 3, NombreSintoma = "Dolor de cabeza" });

            Lstsintomas.Add(new SintomaCovid() { IdSintoma = 4, NombreSintoma = "Alteracion del olfato y gusto"});

            Lstsintomas.Add(new SintomaCovid() { IdSintoma = 5, NombreSintoma = "Cefaleo" });

            Lstsintomas.Add(new SintomaCovid() { IdSintoma = 6, NombreSintoma = "Mialgia" });

            Lstsintomas.Add(new SintomaCovid() { IdSintoma = 7, NombreSintoma = "Bomito o diarea" });

            Lstsintomas.Add(new SintomaCovid() { IdSintoma = 8, NombreSintoma = "Congestion nasal" });

            return Lstsintomas;
        }
        public List<GruposRiesgos> GetGrupoRiesgo()
        {
            List<GruposRiesgos> LstGrupos = new List<GruposRiesgos>();

            LstGrupos.Add(new GruposRiesgos() { IdGrupoRiesgo = 1, NombreGrupoRiesgo = "Mayores de 60", Activo=true });

            LstGrupos.Add(new GruposRiesgos() { IdGrupoRiesgo = 2, NombreGrupoRiesgo = "Enbarazadas", Activo=true });

            LstGrupos.Add(new GruposRiesgos() { IdGrupoRiesgo = 3, NombreGrupoRiesgo = "Persona con enfermedaes cronica", Activo = true });


            return LstGrupos;
        }
    }
}