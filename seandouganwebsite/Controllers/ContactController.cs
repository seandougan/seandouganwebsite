using Microsoft.AspNetCore.Mvc;
using seandouganwebsite.Models.ViewModels;

namespace seandouganwebsite.Controllers;

public class Contact : Controller
{
    // GET
    public IActionResult Index( )
    {

        return View("~/views/Contact.cshtml", new ContactViewModel());
    }
}