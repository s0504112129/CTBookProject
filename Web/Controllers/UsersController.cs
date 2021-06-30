using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web.Controllers
{
  //  [System.Web.Http.Cors]
    public class UsersController : ApiController
    {
        [HttpPost]
        public bool Post([FromBody] UserDto user)
        {

            return BL.UserBL.AddUser(user);

        }
    }
}
