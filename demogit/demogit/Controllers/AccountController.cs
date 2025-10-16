using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace demogit.Controllers
{
    public class AccountController : Controller
    {
        // GET: /Account/Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            // Tài khoản cứng để demo
            string validUser = "admin";
            string validPass = "123";

            if (username == validUser && password == validPass)
            {
                // Lưu tên đăng nhập vào session
                HttpContext.Session.SetString("Username", username);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Error = "Sai tên đăng nhập hoặc mật khẩu!";
                return View();
            }
        }

        // GET: /Account/Logout
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
