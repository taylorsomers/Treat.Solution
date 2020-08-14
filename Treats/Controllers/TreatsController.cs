using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Treats.Models;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Treats.Controllers
{
  [Authorize]
  public class TreatsController : Controller
  {
    private readonly TreatsContext _db;

    private readonly UserManager<ApplicationUser> _userManager;

    public TreatsController(UserManager<ApplicationUser> userManager, TreatsContext db)
    {
      _userManager = userManager;

      _db = db;
    }

    public ActionResult Index()
    {
      List<Treat> model = _db.Treats.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }
  }
}