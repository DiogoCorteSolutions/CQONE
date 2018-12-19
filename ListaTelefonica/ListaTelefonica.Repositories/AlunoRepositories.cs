using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;

namespace ListaTelefonica.Repositories
{
    public class AlunoRepositories
    {
        private readonly ListaTelefonica.Infra.Context.DbContext _context;

        public AlunoRepositories()
        {
            this._context = new Infra.Context.DbContext();
        }

    }
}
