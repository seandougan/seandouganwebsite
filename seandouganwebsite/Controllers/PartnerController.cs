using Microsoft.AspNetCore.Mvc;

namespace seandouganwebsite.Controllers;

public class PartnerController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}