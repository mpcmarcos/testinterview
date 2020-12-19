using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Interview.Models;
using Interview.Data;
using Microsoft.AspNetCore.Authorization;

namespace Interview.Controllers
{
  [Authorize]
  public class TestController : Controller
  {
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _context;

    public TestController(ILogger<HomeController> logger, ApplicationDbContext context)
    {
      _logger = logger;
      _context = context;
    }

    [HttpGet]
    public IActionResult Index()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Index(TwoFieldsViewModel model)
    {
      _context.TwoFields.Add(new TwoFields(model));
      _context.SaveChanges();

      return View();
    }

    public IActionResult List()
    {
      return View(_context.TwoFields);
    }
  }
}
