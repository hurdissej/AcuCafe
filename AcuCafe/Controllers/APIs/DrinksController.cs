using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using AcuCafe.Core;

namespace AcuCafe.Controllers.APIs
{
    public class DrinksController : ApiController
    {
        private IUnitOfWork _unitOfWork;

        public DrinksController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        //Get /api/drinks
        public IHttpActionResult GetDrinks()
        {
            var drinks = _unitOfWork.Drinks.GetDrinks();

            return Ok(drinks);
        }

    }
}
