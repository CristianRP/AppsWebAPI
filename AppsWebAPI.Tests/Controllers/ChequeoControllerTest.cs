using AppsWebAPI.Controllers.MaquinariaControllers;
using AppsWebAPI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppsWebAPI.Tests.Controllers
{
    [TestClass]
    public class ChequeoControllerTest
    {

        [TestMethod]
        public void Get()
        {
            // Disponer
            ChequeoController controller = new ChequeoController();

            // Actuar
            IEnumerable<MQ_CHEQUEO_LISTA_Result> result = controller.Get();

            //Declarar
            Assert.IsNotNull(result);
            Assert.AreNotEqual(0, result.Count());
            
        }

        [TestMethod]
        public void GetById()
        {
            // Disponer
            ChequeoController controller = new ChequeoController();

            // Actuar
            IEnumerable<MQ_CHEQUEO_LISTA_Result> result = controller.Get();
            
            var item = result.FirstOrDefault(i => i.Id == 1);

            // Declarar
            Assert.AreEqual("Gabriel Garcia", item.NombreProveedor);
            Assert.IsInstanceOfType(item, typeof(MQ_CHEQUEO_LISTA_Result));

        }

    }
}
