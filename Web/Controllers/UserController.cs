using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web.Controllers
{
    [System.Web.Http.Cors.EnableCors(origins:"*",headers:"*",methods:"*")]
    public class UserController : ApiController
    {
        
        [HttpPost]
        [Route("api/user")]
        public HttpResponseMessage Post([FromBody] UserDto user)
        {
            //BL.CustomerBL.AddCustomer(user);
              SaveUserResponse response= BL.UserBL.AddUser(user);
            return Request.CreateResponse(HttpStatusCode.OK, response);
            
        }
    }
}
