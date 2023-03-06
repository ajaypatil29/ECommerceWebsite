using ECommerceWebsite.Models;
using ECommerceWebsite.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceWebsite.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService service;
        public UserController(IUserService service)
        {
            this.service = service;
        }

        // GET: UserController
        public ActionResult Index()
        {
            return View(service.GetAllUser());
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            var user = service.GetUserById(id);
            return View(user);
        }
       

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User user)
        {
            try
            {
                int result = service.AddUser(user);
                if (result == 1)
                    return RedirectToAction(nameof(Login));
                else
                    return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            var user = service.GetUserById(id);
            return View(user);
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(User user)
        {
            try
            {
                int result = service.UpdateUser(user);
                if (result == 1)
                    return RedirectToAction(nameof(Index));
                else
                    return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            var user = service.GetUserById(id);
            return View(user);
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                int result = service.DeleteUser(id);
                if (result == 1)
                    return RedirectToAction(nameof(Index));
                else
                    return View();
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Login()
        {
           
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Login(User user)
        {
            var list = service.GetAllUser();
            try
            {
                foreach (var l in list)
                {
                    if (l.RoleId == 1)
                    {
                        if ((l.Email == user.Email) && (l.Password == user.Password))
                        {
                            return RedirectToAction(nameof(Index));
                        }
                    }
                    else
                    {
                        if ((l.Email == user.Email) && (l.Password == user.Password))
                        {
                            return RedirectToAction(nameof(ProductCatController.Index));
                        }
                    }
                   
                    
                        
                }
            }
            catch
            {
                return View();
            }
            return View();
            
            
        }
    }
}
