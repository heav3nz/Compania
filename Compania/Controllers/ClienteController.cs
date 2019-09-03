using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Common;
using System.Data;
using Newtonsoft.Json;
using Compania.DTO;

namespace Compania.Controllers
{
    public class ClienteController : ApiController
    {

        Database db = DatabaseFactory.CreateDatabase("compania");


        // GET: api/Cliente
        [HttpGet]
        public string Get()
        {
            DataSet ds = db.ExecuteDataSet("dbo.spClienteConsultar");

            DataTable dt = new DataTable();
            if (ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
            }

            string JSONresult;
            JSONresult = JsonConvert.SerializeObject(dt);
            return JSONresult;
        }

        // GET: api/Cliente/5
        [HttpGet]
        public string Get(int id)
        {
            DataSet ds = db.ExecuteDataSet("dbo.spClienteConsultarPorId", id);

            DataTable dt = new DataTable();
            if (ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
            }

            string JSONresult;
            JSONresult = JsonConvert.SerializeObject(dt);
            return JSONresult;
        }

        // POST: api/Cliente
        public string Post(Cliente cliente)
        {
            object[] obj = new object[2];
            obj[0] = cliente.nombre;
            obj[1] = cliente.representante;
            DataSet ds = db.ExecuteDataSet("dbo.spClienteInsertar",obj);
            DataTable dt = new DataTable();
            if (ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
            }

            string JSONresult;
            JSONresult = JsonConvert.SerializeObject(dt);
            return JSONresult;
        }

        // PUT: api/Cliente/5
        [HttpPut]
        public string Put(Cliente cliente)
        {
            object[] obj = new object[3];
            obj[0] = cliente.id;
            obj[1] = cliente.nombre;
            obj[2] = cliente.representante;
            DataSet ds = db.ExecuteDataSet("dbo.spClienteModificar", obj);
            DataTable dt = new DataTable();
            if (ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
            }

            string JSONresult;
            JSONresult = JsonConvert.SerializeObject(dt);
            return JSONresult;
        }

        // DELETE: api/Cliente/5
        [HttpDelete]
        public string Delete(int id)
        {
            DataSet ds = db.ExecuteDataSet("dbo.spClienteEliminar", id);
            DataTable dt = new DataTable();
            if (ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
            }

            string JSONresult;
            JSONresult = JsonConvert.SerializeObject(dt);
            return JSONresult;
        }
    }
}
