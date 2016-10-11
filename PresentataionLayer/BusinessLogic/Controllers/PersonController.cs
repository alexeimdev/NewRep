using PresentataionLayer.BusinessLogic.Managers;
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
        public JsonResult GetPerson()
        {
            var model = PersonManager.GetPersonTest();
            return Json(model, JsonRequestBehavior.AllowGet);
        }
    }
}