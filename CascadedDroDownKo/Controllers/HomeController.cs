using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CascadedDroDownKo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            PageVM pageObj = new PageVM();
            List<Country> countryCollection = new List<Country>();
            
            for (int i = 0; i < 10; i++)
            {

                countryCollection.Add(new Country { CountryName = "Country" + i, Id = i });
            }
            pageObj.CountryCollection = countryCollection;

            pageObj.SelectedCountry = "Country3";
            pageObj.SelectedState = "State3";
            pageObj.SelectedCity = "City3";


            return View(pageObj);
        }
        [HttpGet]
        public ActionResult GetStateList(string Country)
        {
            PageVM pageObj = new PageVM();
            List<State> stateCollection = new List<State>();

            for (int i = 0; i < 10; i++)
            {

                stateCollection.Add(new State { StateName = "State" + i, Id = i });
            }
            pageObj.StateCollection = stateCollection;
            pageObj.SelectedState = "State3"; 
            return Json(pageObj,JsonRequestBehavior.AllowGet);
        }

    }

    public class PageVM
    {
        
        public List<Country> CountryCollection { get; set; }
        public List<State> StateCollection { get; set; }
        public List<City> CityCollection { get; set; }

        public string SelectedCountry { get; set; }
        public string SelectedState { get; set; }
        public string SelectedCity { get; set; }
    }

    public class State
    {
        public int Id { get; set; }
        public string StateName { get; set; }
    }
    public class Country
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
    }
    public class City
    {
        public int Id { get; set; }
        public string CityName { get; set; }
    }


}
