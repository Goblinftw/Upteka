using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Upteka.BLL.DTOObjects;
using Upteka.BLL.Services.Interfaces;

namespace Upteka.Controllers
{
    public class ProductController : Controller
    {
        private IProductService m_service;

        public ProductController(IProductService service)
        {
            m_service = service;
        }

        // GET: Product
        public ActionResult Index()
        {
            var products = m_service.GetAll();
            return View(products);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View(m_service.Find(id));
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(ProductDTO item)
        {
            if (!ModelState.IsValid) return View("Create");

            m_service.Add(item);

            return RedirectToAction("Index");
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var p = m_service.Find((int)id);
            return View(p);
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ProductDTO product)
        {
            if (!ModelState.IsValid) return View("Edit");
            try
            {
                m_service.Update(product);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        [HttpPost]
        public JsonResult Delete(int? id)
        {
                if (id != null)
                {
                m_service.Delete((int)id); 
                return Json("OK");
                }
            return Json("incorrect input");
        }
    }
}
