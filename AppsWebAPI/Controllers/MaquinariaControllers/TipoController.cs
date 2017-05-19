using AppsWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace AppsWebAPI.Controllers.MaquinariaControllers
{

    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("")]
    public class TipoController : ApiController
    {

        private Android_DataBaseEntities db = new Android_DataBaseEntities();

        // GET: api/Tipo
        public IEnumerable<MQ_MAQUINAS_LISTADO_TIPO_Result> Get()
        {
            return db.MQ_MAQUINAS_LISTADO_TIPO().AsEnumerable();
        }

    }
}
