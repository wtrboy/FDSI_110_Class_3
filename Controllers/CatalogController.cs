using Microsoft.AspNetCore.Mvc;
using PropertyRental.Models;
using System.Collections.Generic;

namespace PropertyRental.Controllers 
{
    public class CatalogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult AllProperties()
        {

        var list = new List<Property>();
        
        list.Add(new Property()
        {
            Id = 1,
            Bathrooms = 2,
            Description = "The first item on the list",
            ImageUrl = "https://picsum.photos/450/300",
            Title = "Super awesome condo",
            Price = 1275.00m,
            Rooms = 3,
            Area = 300});
            
        list.Add(new Property()
        {
            Id = 1,
            Bathrooms = 1,
            Description = "Something something here the list",
            ImageUrl = "https://picsum.photos/450/300",Title = "Affordable apartment ",
            Price = 1020.30m,
            Rooms = 2,
            Area = 250});
        
        list.Add(new Property()
        {
            Id = 1,
            Bathrooms = 1,
            Description = "Luxury something here the list",
            ImageUrl = "https://picsum.photos/450/300",
            Title = "Luxury apartment ",
            Price = 2020.30m,
            Rooms = 2,
            Area = 450});
            
            return Json(list);
        }

        [HttpPost]
        public IActionResult RegisterProperty ( [FromBody] Property newProp)
        {
            System.Console.WriteLine("Creating a new Property");
            newProp.Id = 1;

            // save the obj to a DB

            return Json(newProp);

        }

    }
}