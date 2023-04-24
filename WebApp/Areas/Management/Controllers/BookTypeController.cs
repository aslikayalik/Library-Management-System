using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Context;
using WebApp.Models;
using WebApp.Repository_Pattern.Interfaces;

namespace WebApp.Areas.Management.Controllers
{
    [Area("Management")]
    [Authorize(Policy = "AdminPolicy")]
    public class BookTypeController : Controller
    {
        IRepository<BookType> _repoBookType;
        public BookTypeController(IRepository<BookType> repoBookType)
        {
            _repoBookType = repoBookType; 
        }
        public IActionResult BookTypeList()
        {
            List<BookType> bookTypes = _repoBookType.GetAll();

            return View(bookTypes); 
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BookType bookType)
        {
            if (!ModelState.IsValid) 
            {
                return View(bookType); 
            }

           _repoBookType.Add(bookType);
            return RedirectToAction("BookTypeList","BookType", new { area = "Management" });
        }

        public IActionResult Edit(int id)
        {
            BookType bookType = _repoBookType.GetById(id);
            return View(bookType);
        }

        [HttpPost]
        public IActionResult Edit(BookType bookType)
        {
             _repoBookType.Update(bookType);
            return RedirectToAction("BookTypeList", "BookType", new { area = "Management" });
        }

        public IActionResult Delete(int id) 
        {
           _repoBookType.SpecialDelete(id);
            return RedirectToAction("BookTypeList", "BookType", new { area = "Management" });
        }

    }
}
