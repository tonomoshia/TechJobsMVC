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
            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search";
            //search all
            if (searchType.Equals("all"))
            {
                // use FindByValue passing in the searchTerm and store the values in the list
                ViewBag.Jobs = JobData.FindByValue(searchTerm);
            }
            // search by category
            else
            {
                //Use the searchTerm and the searchType and use the FindByColumnAndValue method and save that to the list
                ViewBag.Jobs = JobData.FindByColumnAndValue(searchType, searchTerm);
            }
            // set the value of ViewBag.columns property to the column Choices of the ListController class
            // ViewBag.columns = ListController.columnChoices;
            // then set the ViewBag.jobs property to the list

            //then return the index view
            //return View();
            return View("~/Views/Search/Index.cshtml");
        }
    }
}
