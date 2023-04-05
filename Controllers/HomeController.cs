using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Firstproject.Models;

namespace Firstproject.Controllers;

public class HomeController : Controller
{
    public string Index()
    {
        return "Hello world";
    }
}
