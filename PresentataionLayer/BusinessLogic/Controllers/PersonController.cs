using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PresentataionLayer.BusinessLogic.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public JsonResult GetPersonId()
        {  
            var obj = new {
                Id = 5,
                Code = "assert"
            };

            return Json(obj, JsonRequestBehavior.AllowGet);
        }
    }
}