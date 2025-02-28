using Microsoft.AspNetCore.Mvc;

namespace MyNewWebApp.Controllers
{
  [Route("Account")]  // 追加
  public class AccountController : Controller
  {
    [Route("Register")]  // 追加
    public IActionResult Register()
    {
      return View();
    }
  }
}
