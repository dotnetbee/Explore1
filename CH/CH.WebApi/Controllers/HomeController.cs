using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using CH.Manager;

namespace CH.WebApi.Controllers
{
    /// <summary>
    /// This is Home Controller class
    /// </summary>
    public class HomeController : ApiController
    {
        // Create an instance of Home Manager class
        HomeManager _homeManager = new HomeManager(new ManagerLogger());

        // GET: api/Demo
        public string Get()
        {
            return _homeManager.GetWelcomeMessage();
        }
        
        // GET: api/Demo/id
        public string Get(int id)
        {
            return "value";
        }

        // POST: Create a new record 
        [HttpPost]
        public void Create([FromBody]string value)
        {

        }

        // Update the record
        [HttpPut]
        public void Update(int id, [FromBody]string value)
        {

        }

        // DELETE the record 
        public void Delete(int id)
        {

        }
    }
}
