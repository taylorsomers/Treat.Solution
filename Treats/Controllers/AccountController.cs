using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Treats.Models;
using Treats.ViewModels;

namespace Treats.Controllers
{
  public class AccountController : Controller
  {
    private readonly SignInManager<ApplicationUser> _signInManager;

    private readonly TreatsContext _db;

    private readonly UserManager<ApplicationUser> _userManager;

    public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, TreatsContext db)
    {
      _userManager = userManager;
      _signInManager = signInManager;
      _db = db;
    }

    public ActionResult Index()
    {
      return View();
    }

    public IActionResult Register()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Register(RegisterViewModel model)
    {
      var user = new ApplicationUser { UserName = model.Email };
      IdentityResult result = await _userManager.CreateAsync(user, model.Password);
      if (result.Succeeded)
      {
        return RedirectToAction("Index");
      }
      else
      {
        return View();
      }
    }
  }
}