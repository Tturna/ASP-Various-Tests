using ASP_AJAX.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_AJAX.Controllers;

public class JimboController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Index([FromForm] JimboModel data)
    {
        if (!ModelState.IsValid)
        {
            return View(data);
        }

        JimboModel.AddJimbo(data);
        return RedirectToAction("Index", "Home");
    }
}