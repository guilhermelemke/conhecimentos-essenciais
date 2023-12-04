using Microsoft.AspNetCore.Mvc;

namespace AppSemTemplate.Controllers;

public class HomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}