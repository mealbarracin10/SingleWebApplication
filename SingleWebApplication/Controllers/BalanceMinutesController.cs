using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using  SingleWebApplication.Models;

namespace SingleWebApplication.Controllers
{
    public class BalanceMinutesController : ApiController
    {

        Guid[] usersId = new Guid[]{
            new Guid(),
            new Guid(),
            new Guid()
        };
        BalanceUser[] userbalances = new BalanceUser[]{
            new BalanceUser{idBalanceUser = Guid.NewGuid(), idUser = Guid.NewGuid(), MinutesAvailables = 100}
};

        public IEnumerable<BalanceUser> getAllMinutes()
        {
            return userbalances;
        }

        public IHttpActionResult GetUserBalance(Guid userId)
        {
            var userBalance =  userbalances.Select(x=> x.idBalanceUser == userId);
            if (userBalance != null)
                return Ok(userBalance);
            else
                return NotFound();

        }

    }
}
