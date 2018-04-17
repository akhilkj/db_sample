using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BlobAccessApi.Models;
using BlobAccessApi.Controllers;
using System.Data;
using System.Data.SqlClient;

namespace BlobAccessApi.Controllers
{
    public class ValuesController : ApiController
    {
        DAL.userdb dalObj = new DAL.userdb();
       [HttpPost]
       public IHttpActionResult AddingUser([FromBody]User cs)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                dalObj.Addusers(cs);
                return Ok("Success");
            }
            catch(Exception)
            {
                return Ok("Something went wrong");
            }
        }

        public IEnumerable<string>Get()
        {
            return new string[] { "value1", "value2" };
        } 
        public DataSet GetDetails(string uname)
        {
            DataSet ds = dalObj.GetDetailsbyUsername(uname);
            return ds;
        }
        public string Get(string uname)
        {
            return "value";     
        }
    }
}
