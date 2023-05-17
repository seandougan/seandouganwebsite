using Microsoft.AspNetCore.Mvc;

namespace seandouganwebsite.Controllers;

public class LearningController : BaseController
{
    // GET
    public IActionResult Index()
    {
        return View("~/views/Home/Partners.cshtml");
    }
}