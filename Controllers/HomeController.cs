﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EstacionamentoBenner.Models;

namespace EstacionamentoBenner.Controllers;

public class HomeController : Controller
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

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Contratados()
    {
        return View();
    }
    public IActionResult Vendas()
    {
        return View();
    }

    public IActionResult Bau()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}