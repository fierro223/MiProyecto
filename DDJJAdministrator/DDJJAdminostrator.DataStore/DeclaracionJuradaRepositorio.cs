using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDJJAdministrator.Entidades;

namespace DDJJAdministrator.DataStore
{

    public class DeclaracionJuradaRepositorio
    {
        DbOperations dbOperations = new DbOperations();

        static DeclaracionJurada declaracionJuradaTemporal = new DeclaracionJurada();

        static List<DeclaracionJurada> Repositorio = new List<DeclaracionJurada>();
        public void SaveDeclarecionJurada(DeclaracionJurada declaracionJurada)
        {
            Repositorio.Add(declaracionJurada);
        }
        public void SetDeclaracionJuradaTemporal(DeclaracionJurada declaracionJuradaTmp)
        {
            declaracionJuradaTemporal = declaracionJuradaTmp;
        }
        public DeclaracionJurada GetDeclaracionJuradaTemporal()
        {
            return declaracionJuradaTemporal;
        }
        public List<DeclaracionJurada> GetDeclaracionJuradas()
        {
            return Repositorio;
        }


        public bool SaveDeclaracion(DeclaracionJurada declaracionJuradatoSave)
        {
            dbOperations.Operationexecute(declaracionJuradatoSave);

            return true;
        }

    }
}
