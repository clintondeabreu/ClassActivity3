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
    public class SecondController : ApiController
    {
        [System.Web.Mvc.Route("api/second/getTables")]
        public List<dynamic> getTables()
        {
            AnimalsEntities db = new AnimalsEntities();
            List<dynamic> tableList = new List<dynamic>();
            foreach (Vet vet in db.Vets)
            {
                dynamic vets = new ExpandoObject();
                vets.ID = vet.VetID;
                vets.Name = vet.Name;
                vets.Location = vet.Location;
                tableList.Add(vets);
            }
            foreach(Owner owner in db.Owners)
            {
                dynamic owners = new ExpandoObject();
                owners.ID = owner.OwnerID;
                owners.Name = owner.Name;
                owner.Email = owner.Email;
                tableList.Add(owners);
            }
            return tableList;
        }
    }
}