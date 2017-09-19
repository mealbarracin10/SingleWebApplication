using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using SingleWebApplication.Models;

namespace SingleWebApplication.Controllers
{
    public class MinutesController : ApiController
    {

		Prices[] PricesbyUser = new Prices[]{
            new Prices{idPrices = Guid.NewGuid(), idCompany = Guid.NewGuid(), DateCreated= DateTime.Now, DateModified = DateTime.Now, PricesbyMinute = 150, UserModified= "Martin"}
};

        public IEnumerable<Prices> getAllMinutes()
		{
			return PricesbyUser;
		}

		public IHttpActionResult GetUserBalance(Guid pricesId)
		{
            var prices = PricesbyUser.Select(x => x.idPrices == pricesId);
			if (prices != null)
				return Ok(prices);
			else
				return NotFound();
		}
	}
}
