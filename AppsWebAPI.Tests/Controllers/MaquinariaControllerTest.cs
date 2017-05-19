using AppsWebAPI.Controllers.MaquinariaControllers;
using AppsWebAPI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsWebAPI.Tests.Controllers
{
    [TestClass]
    public class MaquinariaControllerTest
    {

        [TestMethod] 
        public void GetMachinery()
        {
            // Disponer 
            MaquinariaController controller = new MaquinariaController();

            // Actuar
            IEnumerable<MQ_MAQUINAS_LISTA_APP_Result> result = controller.Get();

            // Declarar 
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(IEnumerable<MQ_MAQUINAS_LISTA_APP_Result>));
        }

        [TestMethod]
        public void GetMachineryById()
        {
            // Disponer
            MaquinariaController controller = new MaquinariaController();

            // Actuar
            IEnumerable<MQ_MAQUINAS_LISTA_APP_Result> result = controller.Get();
            
            var machinery = result.FirstOrDefault(m => m.id == 1);

            // Declarar
            Assert.IsNotNull(machinery);
        }
    }
}
