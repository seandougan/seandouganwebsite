using Microsoft.AspNetCore.Mvc;

namespace seandouganwebsite.Controllers;

public class ThisApplication : Controller
{
    // GET
    public IActionResult Index()
    {
        return View("~/views/ThisApplication.cshtml");
    }
}