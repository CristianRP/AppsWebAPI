using AppsWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;

namespace AppsWebAPI.Controllers.MaquinariaControllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("")]
    public class MaquinariaController : ApiController
    {
        private Android_DataBaseEntities db = new Android_DataBaseEntities();

        // GET: api/Maquinaria
        public IEnumerable<MQ_MAQUINAS_LISTA_APP_Result> Get()
        {
            return db.MQ_MAQUINAS_LISTA_APP().AsEnumerable();
        }

        // GET: api/Maquinaria/5
        [ResponseType(typeof(MQ_MAQUINAS_LISTA_APP_Result))]
        public IHttpActionResult Get(string codigoMaquina)
        {
            var result = db.MQ_MAQUINAS_LISTA_APP().AsEnumerable();
            var machinery = result.FirstOrDefault(m => m.codigo == codigoMaquina);
            if (machinery == null)
            {
                //return Json(new { error = "Maquina no encontrada o codigo no registrado. Consulte el inventario de maquinaria." });
                return NotFound();
            }
            return Ok(machinery);
        }

    }
}
