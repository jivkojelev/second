using AnotherFuckngProject.Models;
using AnotherFuckngProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace AnotherFuckngProject.Controllers
{
    public class UsersController : Controller
    {
        //
        // GET: /Users/
        public ActionResult Details(int? id)
        {
            User user = new UsersRepository().GetAll().FirstOrDefault(u => u.ID == id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        public ActionResult List()
        {
            List<User> users = new UsersRepository().GetAll().ToList();
            return View(users);
        }


        public ActionResult Edit(int id)
        {
            User user = new UsersRepository().GetAll().FirstOrDefault(u => u.ID == id);
            return View(user);
        }

        [HttpPost]
        public ActionResult Edit(User user)
        {
            UsersRepository repo = new UsersRepository();
            repo.Update(user);
            return RedirectToAction("List");
        }

        public ActionResult Delete(int id)
        {
            UsersRepository repo = new UsersRepository();
            repo.Delete(id);
            return RedirectToAction("List");
        }

        public ActionResult Create()
        {
            User user = new User();
            return View(user);
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            UsersRepository repo = new UsersRepository();
            repo.Insert(user);
            return RedirectToAction("List");
        }

    }

}