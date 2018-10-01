using MyPark.Model.DataBase.Models;
using NHibernate;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPark.Model.DataBase.Repository
{
    public class EstadiaRepository : RepositoryBase<estadia>
    {
        public EstadiaRepository(ISession session) : base(session) { }

        public estadia BuscarAtivaPelaPlaca(String placa)
        {
            var estadia = Session.Query<estadia>()
                .FirstOrDefault(f => f.Veiculo.Placa == placa
                                  && f.Dtsaida == new DateTime()); 

            return estadia;
        }

        public List<estadia> BuscarAtivas()
        {
            var estadias = Session.Query<estadia>()
                .Where(w => w.Dtsaida == new DateTime())
                .ToList();

            return estadias;
        }

    }
}
