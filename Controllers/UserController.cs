using Microsoft.AspNetCore.Mvc;
using PracticalTest.Models;
using PracticalTest.Service;
using System.Collections.Generic;

namespace PracticalTest.Controllers
{
    public class UserController : Controller
    {
        readonly IUserService _userService;
        //Constructor DI
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        public ActionResult GetAllUsers()
        {
            List<User> allproducts = _userService.GetAllUsers();
            return View(allproducts);
        }
        [HttpGet]
        public ActionResult AddUser()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult AddUser(User user)
        {
            if (ModelState.IsValid)
            {
                _userService.AddUser(user);
                return RedirectToAction("GetAllUsers");
            }
            else
            {
                return View(user);
            }
        }
            public ActionResult Delete(int id)
            {
                _userService.Delete(id);
                return RedirectToAction("GetAllUsers");
            }
        public ActionResult Details(int id)
        {
            User user = _userService.Details(id);
            return View(user);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var record = _userService.GetUserById(id);
            return View(record);
        }
        [HttpPost]
        public ActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                _userService.Edit(user);
                return RedirectToAction("GetAllUsers");
            }
            else
            {
                return View(user);
            }

        }





    }
}
