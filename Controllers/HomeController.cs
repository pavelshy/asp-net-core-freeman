using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Firstproject.Models;

namespace Firstproject.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public ViewResult RsvpForm()
    {
        return View();
    }

    [HttpPost]
    public ViewResult RsvpForm(GuestResponse guestResponse)
    {
        Repository.AddResponse(guestResponse);
        
        return View("Thanks", guestResponse);
    }
    
}

