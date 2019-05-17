using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassActivity3.Models;
using System.Web.Http;
using System.Net.Http;
using System.Net;
using System.Dynamic;
using System.Web.Http.Cors;

namespace ClassActivity3.Controllers
{
    [EnableCors(origins:"*",headers:"*",methods:"*")]
    public class FirstController : ApiController
    {
        [System.Web.Mvc.Route("api/first/getVets")]
        public List<dynamic> getVets()
        {
            AnimalsEntities db = new AnimalsEntities();
            List<dynamic> vetList = new List<dynamic>();
            foreach(Vet vet in db.Vets)
            {
                dynamic vets = new ExpandoObject();
                vets.ID = vet.VetID;
                vets.Name = vet.Name;
                vets.Location = vet.Location;
                vetList.Add(vets);
            }
            return vetList;
        }
    }
}