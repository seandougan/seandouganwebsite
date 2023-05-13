using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using seandouganwebsite.Models;
using seandouganwebsite.Services;
using seandouganwebsite.Services.Abstractions;

namespace seandouganwebsite.Controllers;

public class HomeController : BaseController
{
    private readonly ILogger<HomeController> _logger;
    private readonly ILocalizationService _localizer;

    public HomeController(ILogger<HomeController> logger, ILocalizationService localizer)
    {
        _logger = logger;
        _localizer = localizer;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult GithubSean()
    {
        return Redirect("https://github.com/seandougan");
    }

    public IActionResult Partners()
    {
        return View();
    }

    
}