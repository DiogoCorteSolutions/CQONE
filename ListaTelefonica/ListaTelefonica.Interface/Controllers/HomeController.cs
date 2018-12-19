using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ListaTelefonica.Infra.Models;
using ListaTelefonica.Interface.Models;
using NHibernate;
using NHibernate.Linq;

namespace ListaTelefonica.Interface.Controllers
{
    public class HomeController : Controller
    {
        private readonly ListaTelefonica.Infra.Context.DbContext _context;
        private readonly Repositorio.Repositories _repository;
        public HomeController()
        {
            this._context = new Infra.Context.DbContext();
            this._repository = new Repositorio.Repositories();
        }
        // GET: Home
        public ActionResult Index()
        {
            //using (ISession session = ListaTelefonica.Infra.Context.DbContext.OpenSession())
            //{
            //    var agenda = session.Query<Agenda>().ToList();
            //    return View(agenda);
            //}

            return View(this._repository.ListarTodos());
        }
        public ActionResult Details(int id)
        {
            using (ISession session = ListaTelefonica.Infra.Context.DbContext.OpenSession())
            {
                var agenda = session.Get<Agenda>(id);
                return View(agenda);
            }
        }
        public ActionResult Create()
        {

            var model = new Agenda();
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(Agenda agenda)
        {
            try
            {
                this._repository.Salvar(agenda);
                return RedirectToAction("Index");
            }
            catch
            {

                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            using (ISession session = ListaTelefonica.Infra.Context.DbContext.OpenSession())
            {
                var agenda = session.Get<Agenda>(id);
                return View(agenda);
            }
        }

        [HttpPost]
        public ActionResult Edit(int id, Agenda agenda)
        {
            try
            {
                this._repository.Alterar(id, agenda);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Delete(int id)
        {
            using (ISession session = ListaTelefonica.Infra.Context.DbContext.OpenSession())
            {
                var agenda = session.Get<Agenda>(id);
                return View(agenda);
            }
        }

        [HttpPost]
        public ActionResult Delete(int id, Agenda agenda)
        {
            try
            {
                using (ISession session = ListaTelefonica.Infra.Context.DbContext.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        var retorno = new ListaTelefonica.Infra.Models.Agenda()
                        {
                            IdAgenda = id,
                            NomeContato = agenda.NomeContato,
                            EmailResidencial = agenda.EmailResidencial,
                            EmailComercial = agenda.EmailComercial,
                            EmailOutro = agenda.EmailOutro,
                            TelefoneResidencial = agenda.TelefoneResidencial,
                            TelefoneComercial = agenda.TelefoneComercial,
                            TelefoneOutro = agenda.TelefoneOutro,
                            Empresa = agenda.Empresa,
                            Endereco = agenda.Endereco,
                            TelefoneContato = agenda.TelefoneContato,
                            EmailContato = agenda.EmailContato

                        };
                        session.Delete(retorno);
                        transaction.Commit();
                    }
                }
                return RedirectToAction("Index");
            }

            catch (Exception exception)
            {
                TempData["msgerror"] = exception.Message.ToString();
                return RedirectToAction("index", "home");
            }
            //catch
            //{
            //    return View("Index","Home");
            //}
        }

        public bool ValidaNumeroTelResidencia(string TelefoneResidencial)
        {
            bool flag = false;
            if (!string.IsNullOrEmpty(TelefoneResidencial))
            {
                if (TelefoneResidencial.Length > 8)
                {
                    flag = true;
                }
            }
            return flag;
        }


    }
}