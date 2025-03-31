using FlipLoginAndRegister.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

using System.Collections.Generic;
using System.Linq;

namespace FlipLoginAndRegister.Controllers;

    public class HomeController : Controller
    {
        private readonly AppDBContext _dbContext;
    public HomeController(AppDBContext dbContext)
    {
        _dbContext = dbContext;
    }
       

        public IActionResult Register(UserData data)
        {
        if (ModelState.IsValid)
        {
            _dbContext.UsersList.Add(data);
            _dbContext.SaveChanges();
            ViewBag.SuccessMessage = "Registration successful! Welcome aboard.";
            return RedirectToAction("Login");
        }
        return View();


    }

    public IActionResult Login(LoginData data)
    {
        if (ModelState.IsValid)
        {
            var user=_dbContext.UsersList.FirstOrDefault(u=>u.Email==data.Email && u.Password==data.Password);
            if(user!=null)
            {
                TempData["SuccessMessage"] = "Login successful";
                return RedirectToAction("Index","Product");
            }
            else
            {
                ViewBag.ErrorMessage = "Invalid Email or Password";
            }
        }
        return View();
    }
    }

