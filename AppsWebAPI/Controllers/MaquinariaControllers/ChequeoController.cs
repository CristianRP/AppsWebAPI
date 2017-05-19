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
    public class ChequeoController : ApiController
    {
        private Android_DataBaseEntities db = new Android_DataBaseEntities();

        // GET: api/Chequeo
        public IEnumerable<MQ_CHEQUEO_LISTA_Result> Get()
        {
            return db.MQ_CHEQUEO_LISTA().AsEnumerable();
        }

        // GET: api/Chequeo/5
        public IHttpActionResult Get(int id)
        {
            var result = db.MQ_CHEQUEO_LISTA().AsEnumerable();
            var chequeo_maquina = result.FirstOrDefault(c => c.Id == id);

            if (chequeo_maquina == null)
            {
                return NotFound();
            }

            return Ok(chequeo_maquina);
        }

        // POST: api/Chequeo
        [ResponseType(typeof(Chequeo))]
        public async Task<IHttpActionResult> Post(Chequeo chequeo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.MQ_CHEQUEO_INSERT(chequeo.SistemaElectrico, chequeo.Cilindros, chequeo.BombaHD,
                chequeo.RodajeCadena, chequeo.Cuchilla, chequeo.Llantas, chequeo.Mangueras,
                chequeo.Sillones, chequeo.Vidrios, chequeo.Motor, chequeo.Otros, chequeo.CodigoMaquina,
                chequeo.CodigoSupervisor);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = chequeo.Id }, chequeo);
        }

        // PUT: api/Chequeo/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Chequeo/5
        public void Delete(int id)
        {
        }
    }
}
