using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Interview.Models;
using Interview.Services;
using Microsoft.AspNetCore.Authorization;

namespace Interview.Controllers
{
  [Authorize]
  public class PullRequestController : Controller
  {
    private readonly ILogger<HomeController> _logger;
    private readonly IMailService mailService;
    private readonly ISmsService smsService;

    public PullRequestController(ILogger<HomeController> logger, IMailService MailService, ISmsService SmsService)
    {
      _logger = logger;
      mailService = MailService;
      smsService = SmsService;
    }

    public IActionResult Index()
    {
      mailService.Send("test@test.com", "test@test.com", "body");
      smsService.Send("111111", "message");

      return RedirectToAction("List", "Test");
    }
  }
}
