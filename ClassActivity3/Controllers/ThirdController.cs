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

namespace ClassActivity3.Controllers
{
    public class ThirdController : ApiController
    {
        [System.Web.Mvc.Route("api/first/getVets")]
        public List<dynamic> getVets()
        {
            AnimalsEntities db = new AnimalsEntities();
            List<dynamic> vetList = new List<dynamic>();
            foreach (Vet vet in db.Vets)
            {
                dynamic vets = new ExpandoObject();
                vets.ID = vet.VetID;
                vets.Name = vet.Name;
                vets.Location = vet.Location;
                vetList.Add(vets);
            }
            return vetList;
        }
        [System.Web.Mvc.Route("api/third/addVets")]
        public List<dynamic> addVets ([FromBody] List<Vet> vets)
        {
            AnimalsEntities db = new AnimalsEntities();
            db.Configuration.ProxyCreationEnabled = false;
            db.Vets.AddRange(vets);
            db.SaveChanges();
            return getVets();
        }
    }
}