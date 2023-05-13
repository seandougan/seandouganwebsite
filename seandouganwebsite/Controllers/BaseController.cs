﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using seandouganwebsite.Models;

namespace seandouganwebsite.Controllers;

public abstract class BaseController : Controller
{
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}