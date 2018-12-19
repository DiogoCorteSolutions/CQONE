using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ListaTelefonica.Infra.Models;
using NHibernate;
using NHibernate.Linq;

namespace ListaTelefonica.Interface.Repositorio
{
    public class Repositories
    {
        private readonly ListaTelefonica.Infra.Context.DbContext _context;
        public Repositories()
        {

            this._context = new Infra.Context.DbContext();
        }

        public List<Agenda> ListarTodos()
        {
            using (ISession session = ListaTelefonica.Infra.Context.DbContext.OpenSession())
            {
                var agenda = session.Query<Agenda>().ToList();
                return agenda;
            }
        }

        public void Salvar(Agenda agenda)
        {
            using (ISession session = ListaTelefonica.Infra.Context.DbContext.OpenSession())
            {
                try
                {

                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Save(agenda);
                        transaction.Commit();
                    }
                }
                catch (Exception)
                {

                    throw;
                }

            }

        }

        public void Alterar(int id, Agenda agenda)
        {
            try
            {
                using (ISession session = ListaTelefonica.Infra.Context.DbContext.OpenSession())
                {
                    var agendaAlterada = session.Get<Agenda>(id);
                    agendaAlterada.NomeContato = agenda.NomeContato;
                    agendaAlterada.EmailContato = agenda.EmailContato;
                    agendaAlterada.EmailResidencial = agenda.EmailResidencial;
                    agendaAlterada.EmailComercial = agenda.EmailComercial;
                    agendaAlterada.EmailOutro = agenda.EmailOutro;
                    agendaAlterada.TelefoneContato = agenda.TelefoneContato;
                    agendaAlterada.TelefoneResidencial = agenda.TelefoneResidencial;
                    agendaAlterada.TelefoneComercial = agenda.TelefoneComercial;
                    agendaAlterada.TelefoneOutro = agenda.TelefoneOutro;
                    agendaAlterada.Empresa = agenda.Empresa;
                    agendaAlterada.Endereco = agenda.Endereco;
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Save(agendaAlterada);
                        transaction.Commit();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Excluir1(Agenda agenda)
        {
            try
            {
                using (ISession session = ListaTelefonica.Infra.Context.DbContext.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Delete(agenda);
                        transaction.Commit();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

       
    }
}