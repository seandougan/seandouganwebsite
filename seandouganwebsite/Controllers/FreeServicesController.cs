using Microsoft.AspNetCore.Mvc;

namespace seandouganwebsite.Controllers;

public class FreeServices : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}