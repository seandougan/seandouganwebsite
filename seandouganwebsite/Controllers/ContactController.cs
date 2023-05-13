using Microsoft.AspNetCore.Mvc;

namespace seandouganwebsite.Controllers;

public class Contact : Controller
{
    // GET
    public IActionResult Index()
    {
        return View("~/views/Contact.cshtml");
    }
}