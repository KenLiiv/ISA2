using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Core;
using Infra;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace MVC.Controllers
{
    public class AuthenticationController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
		[HttpPost]
		public async Task<IActionResult> DoLogin(UserDetails u)
		{
			if (ModelState.IsValid)
			{
				if (Employees.IsValidUser(u))
				{
					await setIdentity(u);
					return RedirectToAction("Index", "Employee");
				}
				ModelState.AddModelError("CredentialError", "Invalid username or password!!");
				return View("Login");
			}
			return View("Login");
		}
		private async Task setIdentity(UserDetails u)
		{
			List<Claim> claims = new List<Claim> { new Claim(ClaimTypes.Name, u.UserName) };
			ClaimsIdentity identity = new ClaimsIdentity(claims, "cookie");
			ClaimsPrincipal principal = new ClaimsPrincipal(identity);
			await HttpContext.SignInAsync(scheme: "AuthScheme", principal: principal);
		}
		public async Task<IActionResult> Logout()
		{
			await HttpContext.SignOutAsync(scheme: "AuthScheme");
			return RedirectToAction("Login");
		}
    }
}