using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookGUI.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookGUI.Controllers
{
    public class CountriesController : Controller
    {
        ICountryRepositoryGUI countryRepository;

        // Constructor dependency injection. Injected in Startup.ConfigureServices();
        public CountriesController(ICountryRepositoryGUI countryRepository)
        {
            this.countryRepository = countryRepository;
        }

        public IActionResult Index()
        {
            var countries = countryRepository.GetCountries();

            if (countries.Count() <= 0)
            {
                ViewBag.Message = "There was a problem retrieving countries from the " +
                    "database or no country exists. ";
            }

            return View(countries);
        }
    }
}
