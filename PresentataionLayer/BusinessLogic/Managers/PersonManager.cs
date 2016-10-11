using PresentataionLayer.DataEnteties.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentataionLayer.BusinessLogic.Managers
{
    public static class PersonManager
    {
        public static Person GetPersonTest()
        {
            return new Person
            {
                Id = 4,
                Name = "Alex"
            };
        }
    }
}