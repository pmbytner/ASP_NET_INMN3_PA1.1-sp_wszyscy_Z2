using Microsoft.AspNetCore.Mvc;
using ASP_NET_INMN3_PA1_1_sp_wszyscy_Z2.Models;

namespace ASP_NET_INMN3_PA1_1_sp_wszyscy_Z2.Controllers;
public class WitajController : Controller
{
    public IActionResult Index(string? id)
    {
        if(id == null)
            ViewData["Komunikat"] = "nie otrzymałem id w zapytaniu";
        else
            ViewData["Komunikat"] = $"id to {id}";
        return View();
    }
    public IActionResult Witaj(string? imię, int? ilość)
    {
        /*ViewData["Imię"] = imię;
        ViewData["Ilość"] = ilość;
        return View()*/
        //powyższe niewskazane, często wymaga rzutowania

        /*return View(
            (Imię: imię, Ilość: ilość)
            );*/
        //powyższe jest lepsze, o ile w widoku zadeklarujemy model

        return View(
            new WitajViewModel() { Imię = imię, Ilość = ilość }
            );
    }
}
