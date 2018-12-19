using Microsoft.VisualStudio.TestTools.UnitTesting;
using ListaTelefonica.Interface.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTelefonica.Interface.Repositorio.Tests
{

    [TestClass()]
    public class RepositoriesTests
    {
        private readonly Repositorio.Repositories _repository;
        public RepositoriesTests()
        {
            this._repository = new Repositorio.Repositories();
        }
        [TestMethod()]
        public void RepositoriesTest()
        {
           Repositories repository = new Repositories();
            
        }

        [TestMethod()]
        public void ListarTodosTest()
        {
            var model = new ListaTelefonica.Infra.Models.Agenda();

            Assert.Fail();
        }

        [TestMethod()]
        public void SalvarTest()
        {
            var model = new ListaTelefonica.Infra.Models.Agenda();
            model.TelefoneComercial.Equals(null);
            model.EmailContato.Equals(null);

            Assert.Fail();
        }

        [TestMethod()]
        public void AlterarTest()
        {
            Assert.Fail();
        }
    }
}