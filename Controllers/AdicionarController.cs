using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SIRP.Models;

namespace SIRP.Controllers;

public class AdicionarController : Controller
{
    private readonly ILogger<AdicionarController> _logger;


    public IActionResult AdicionarContratado()
    {
        return View();
    }
}
