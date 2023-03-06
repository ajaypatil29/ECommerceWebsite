using ECommerceWebsite.Models;
using ECommerceWebsite.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Plugins;

namespace ECommerceWebsite.Controllers
{
    public class ProductCatController : Controller
    {
        private readonly IProductCatService service;
        public ProductCatController(IProductCatService service)
        {
            this.service = service;
        }

        public ActionResult Index()
        {
            return View(service.GetAllCat());
        }

        // GET: ProductCatController/Details/5
        public ActionResult Details(int id)
        {
            var cat = service.GetCatById(id);
            return View(cat);
        }

        // GET: ProductCatController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductCatController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductCat cat)
        {
            try
            {
                int result =service.AddCat(cat);
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

        // GET: ProductCatController/Edit/5
        public ActionResult Edit(int id)
        {
            var cat = service.GetCatById(id);
            return View(cat);
        }

        // POST: ProductCatController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProductCat cat)
        {
            try
            {
                int result = service.UpdateCat(cat);
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

        // GET: ProductCatController/Delete/5
        public ActionResult Delete(int id)
        {
            var cat = service.GetCatById(id);
            return View(cat);
        }

        // POST: ProductCatController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                int result = service.DeleteCat(id);
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
    }
}
