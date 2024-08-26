using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;
public class HomeController : Controller
{
    // private readonly ILogger<HomeController> _logger;

    private readonly IMyService  _myservice;


    public HomeController(IMyService MyService )
    {
        _myservice = MyService;
    }

    // public HomeController(ILogger<HomeController> logger)
    // {
    //     _logger = logger;
    // }

    public IActionResult Index()
    {
        var message = _myservice.GetMessage();
        ViewBag.Message = message;
        return View();
    
    }

    public IActionResult Privacy()
    {
            ViewBag.Title = "Privacy Policy";
    ViewBag.Countries = new List<string> { "USA", "Canada", "Mexico" };
        return View();

    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public JsonResult GetData()
    {
        var data = new { Name = "Alice", Age = 30 };
        return Json(data);
    }

    public IActionResult NotFoundPage()
    {
        return StatusCode(404);
    }

    public IActionResult RedirectToHome()
    {
        return RedirectToAction("Index");
    }


    public IActionResult Create()
        {
            return View();
        }

        // Handle form submission and bind data to the Product model
        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                // Process the product (e.g., save to the database)
                // _context.Products.Add(product);
                // _context.SaveChanges();

                return RedirectToAction("Index");
            }

            // If validation fails, return the same view with validation errors
            return View(product);
        }
}


