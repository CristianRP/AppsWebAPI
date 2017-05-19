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
    public class ReparacionController : ApiController
    {
        private Android_DataBaseEntities db = new Android_DataBaseEntities();

        // GET: api/Reparacion
        public IEnumerable<MQ_REPARACION_LISTA_Result> Get()
        {
            return db.MQ_REPARACION_LISTA().AsEnumerable();
        }

        // GET: api/Reparacion/5
        public IHttpActionResult Get(int id)
        {
            var result = db.MQ_REPARACION_LISTA().AsEnumerable();
            var reparacion = result.FirstOrDefault(r => r.Codigo_Maquina == id);
            if (reparacion == null)
            {
                return Ok();
            }
            return Ok(reparacion);
        }

        // POST: api/Reparacion
        [ResponseType(typeof(Reparacion))]
        public async Task<IHttpActionResult> Post(Reparacion reparacion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.MQ_REPARACION_INSERT(reparacion.FechaParalizacion, reparacion.FechaInicio,
                reparacion.EstadoReparacion, reparacion.FechaFin, reparacion.DiasAsignados,
                reparacion.CodigoMaquina, reparacion.Diagnostico);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = reparacion.CodigoMaquina }, reparacion);
        }

        // PUT: api/Reparacion/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Reparacion/5
        public void Delete(int id)
        {
        }
    }
}
