using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using RuppinRent.Models;

namespace RuppinRent.Controllers
{
    public class HousesController : ApiController
    {
        public IEnumerable<House> Get()
        {
            House h = new House();
            List<House> houses = h.GetHouses();
            return houses;
        }

        public House Get(int id)
        {
            House h = new House();
            House house = h.GetHouseById(id);
            return house;
        }

        public IEnumerable<House> Get(string name)
        {
            House h = new House();
            List<House> houses = h.GetHousesByName(name);
            return houses;
        }

        public void Put(int id, [FromBody] string value)
        {
        }


        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }

    }
}