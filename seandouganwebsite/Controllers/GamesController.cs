using Microsoft.AspNetCore.Mvc;

namespace seandouganwebsite.Controllers;

public class GamesController : BaseController
{
    // GET
    public IActionResult Index()
    {
        return View("~/views/Home/Partners.cshtml");
    }
}