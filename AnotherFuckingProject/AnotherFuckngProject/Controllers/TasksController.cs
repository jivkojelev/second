using AnotherFuckngProject.Models;
using AnotherFuckngProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnotherFuckngProject.Controllers
{
    public class TasksController : Controller
    {
        // GET: Tasks
        public ActionResult Index(int? id)
        {
            TasksRepository repo = new TasksRepository();
            List<Task> tasks = new List<Task>();

            if(id == null)
            {
                tasks = repo.GetAll().ToList();
            }
            else 
                tasks = repo.GetAll().Where(t => t.UserID == id).ToList();
            return View(tasks);
        }
        

        public ActionResult Create()
        {
            Task task = new Task();
            return View(task);
        }

        [HttpPost]
        public ActionResult Create(Task task)
        {
            TasksRepository repo = new TasksRepository();
            repo.Insert(task);

            return RedirectToAction("List", new { id = task.UserID });
        }


        public ActionResult Details(int? id)
        {
            Task task = new TasksRepository().GetAll().FirstOrDefault(u => u.ID == id);
            if (task == null)
            {
                return HttpNotFound();
            }
            return View(task);
        }



        public ActionResult Edit(int id)
        {
            Task task = new TasksRepository().GetAll().FirstOrDefault(u => u.ID == id);
            return View(task);
        }

        [HttpPost]
        public ActionResult Edit(Task task)
        {
            TasksRepository repo = new TasksRepository();
            repo.Update(task);
            return RedirectToAction("List", new { id = task.UserID });
        }

        public ActionResult Delete(int id)
        {
            TasksRepository repo = new TasksRepository();
            repo.Delete(id);
            return RedirectToAction("List");
        }

    }
}