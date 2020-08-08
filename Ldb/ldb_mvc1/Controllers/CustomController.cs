﻿using System;

using System.Collections.Generic;

using System.Linq;

using System.Web;
using ldb_mvc1.Controllers.DataAccess;
using ldb_mvc1.Models;
using Microsoft.AspNetCore.Mvc;

namespace ldb_mvc1.Controllers
{
    public class CustomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

         [HttpGet]
         public ActionResult InsertUserProfile()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InsertUserProfile(UserProfile user)
        {
            user.dob = Convert.ToDateTime(user.dob);
            if (ModelState.IsValid)
            {
                DataAccessLayer db = new DataAccessLayer();
                string result = db.Insert(user);
                ViewData["result"] = result;
                ModelState.Clear();
                return View();
            }
            else
            {
                ModelState.AddModelError("", "Error saving data");
                return View();
            }
        }
        
        [HttpGet]
        public ActionResult ShowAllUserProfiles()
        {
            UserProfile user = new UserProfile();
            DataAccessLayer db = new DataAccessLayer();
            user.ShowAllUserProfiles = db.RetrieveProfiles();
            return View(user);
        }

        [HttpGet]
        public ActionResult Edit(string ID)
        {
            UserProfile user = new UserProfile();
            DataAccessLayer db = new DataAccessLayer();
            return View(db.RetrieveByEmail(ID));
        }

        [HttpPost]
        public ActionResult Edit(UserProfile user)
        {
            user.dob = Convert.ToDateTime(user.dob);
            if(ModelState.IsValid)
            {
                DataAccessLayer db = new DataAccessLayer();
                string result = db.Update(user);
                ViewData["result"] = result;
                ModelState.Clear();
                return View();
            }
            else
            {
                ModelState.AddModelError("", "error in saving data");
                return View();
            }
        }
        [HttpGet]
        public ActionResult Delete(string email)
        {
            DataAccessLayer db = new DataAccessLayer();
            UserProfile user = new UserProfile();
            return View(db.RetrieveByEmail(email));
        }
        [HttpPost]
        public ActionResult Delete(UserProfile user)
        {

            DataAccessLayer db = new DataAccessLayer();
            string result = db.DeleteData(user);
            ViewData["result"] = result;
            ModelState.Clear();
            return View();

        }

    }
}