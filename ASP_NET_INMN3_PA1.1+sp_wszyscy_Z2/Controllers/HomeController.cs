using ASP_NET_INMN3_PA1_1_sp_wszyscy_Z2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASP_NET_INMN3_PA1_1_sp_wszyscy_Z2.Controllers;
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

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(
            new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier }
            );
    }
}
