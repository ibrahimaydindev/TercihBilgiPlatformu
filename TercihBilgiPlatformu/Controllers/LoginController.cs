﻿using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace TercihBilgiPlatformu.Controllers
{
  [AllowAnonymous]
  public class LoginController : Controller
  {
    Context _ctx = new Context();

    [HttpGet]
    public IActionResult SignIn()
    {
      return View();
    }

    [HttpPost]
    public async Task<IActionResult> SignIn(Kullanici kullanici)
    {
      var value = _ctx.Kullanicis.FirstOrDefault(x => x.EMail == kullanici.EMail && x.Sifre == kullanici.Sifre);

      if (value != null)
      {
        var claims = new List<Claim> { new Claim(ClaimTypes.Name,kullanici.EMail)};
        var userIdentity = new ClaimsIdentity(claims,"a");
        ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(userIdentity);
        await HttpContext.SignInAsync(claimsPrincipal);
        return RedirectToAction("Index","Home");
      }
      return View();
    }

    [HttpGet]
    public async Task<IActionResult> LogOut()
    {
      await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
      return RedirectToAction("SignIn","Login");
    }

    public IActionResult SignUp()
    {
      return View();
    }

    public IActionResult Forgot()
    {
      return View();
    }
  }
}
