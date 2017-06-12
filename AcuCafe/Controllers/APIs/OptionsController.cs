using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using AcuCafe.Core;

namespace AcuCafe.Controllers.APIs
{
    public class OptionsController: ApiController
    {
        private IUnitOfWork unitOfWork;

        public OptionsController(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }

        //Get /api/Options
        public IHttpActionResult GetOptions()
        {
            var result = unitOfWork.Options.GetOptions();

            return Ok(result);
        }

    }
}