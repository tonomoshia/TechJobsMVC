using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechJobs.Models;

namespace TechJobs.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search";
            return View();
        }

        // TODO #1 - Create a Results action method to process 
        // search request and display results

        public IActionResult Results(string searchType, string searchTerm = "")
        {
            // Create a list to store queried results to be returned

            if (searchType.Equals("all"))
            {
                //use FindByValue passing in the searchTerm and store the values in the list
            }
            else
            {
                //Use the searchTerm and the searchType and use the FindByColumnAndValue method and save that to the list
            }
            //set the value of ViewBag.columns property to the column Choices of the ListController class
            //then set the ViewBag.jobs property to the list
            //then return the index view
        }
    }
}
