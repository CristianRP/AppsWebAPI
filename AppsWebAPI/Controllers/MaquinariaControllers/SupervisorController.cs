using AppsWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;

namespace AppsWebAPI.Controllers.MaquinariaControllers
{
    public class SupervisorController : ApiController
    {

        private Android_DataBaseEntities db = new Android_DataBaseEntities();

        // GET: api/Supervisor
        public IHttpActionResult Get(string username, string password)
        {
            
            var supervisor = db.MQ_LOGIN_SUPERVISOR(username, password).FirstOrDefault();
            //var super = supervisor.First();
            if (supervisor == null)
            {
                //return NotFound(Json(new { error = "Usuario no registrado o credenciales invalidas" }));
                return NotFound();
            }
            return Ok(supervisor);
        }

        /* public IHttpActionResult Get(int id)
        {
            var result = db.MQ_REPARACION_LISTA().AsEnumerable();
            var reparacion = result.FirstOrDefault(r => r.Codigo_Maquina == id);
            if (reparacion == null)
            {
                return Ok();
            }
            return Ok(reparacion);
        }
*/

        // GET: api/Supervisor/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Supervisor
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Supervisor/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Supervisor/5
        public void Delete(int id)
        {
        }
    }
}
