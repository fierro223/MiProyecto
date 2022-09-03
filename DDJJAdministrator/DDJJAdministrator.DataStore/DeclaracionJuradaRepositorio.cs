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
        static List<DeclaracionJurada> Repositorio = new List<DeclaracionJurada>();
        public void SaveDeclaracionJurada(DeclaracionJurada declaracionJurada)
        {
            Repositorio.Add(declaracionJurada);
        }
        public List<DeclaracionJurada> GetDeclaracionJuradas()
        {
            return Repositorio;
        }
    }
}
