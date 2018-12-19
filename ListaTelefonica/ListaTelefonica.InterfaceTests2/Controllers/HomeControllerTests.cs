using Microsoft.VisualStudio.TestTools.UnitTesting;
using ListaTelefonica.Interface.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTelefonica.Interface.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        [TestMethod()]
        public void ValidaNumeroTelResidenciaNuloTest()
        {
            HomeController home = new HomeController();

            Assert.IsTrue(home.ValidaNumeroTelResidencia(null));
        }

        public void ValidaNumeroTelResidenciaMenor8PosicoesTest()
        {
            HomeController home = new HomeController();

            Assert.IsTrue(home.ValidaNumeroTelResidencia("4666"));
        }

        public void ValidaNumeroTelResidenciaMaior8PosicoesTest()
        {
            HomeController home = new HomeController();

            Assert.IsTrue(home.ValidaNumeroTelResidencia("466624444"));
        }
    }
}

    
