﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using seandouganwebsite.Models;

namespace seandouganwebsite.Controllers;

public class HomeController : BaseController
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult GithubSean()
    {
        return Redirect("https://github.com/seandougan");
    }

    public IActionResult Privacy()
    {
        return View();
    }

    
}