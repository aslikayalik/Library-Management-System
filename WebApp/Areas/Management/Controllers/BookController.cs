using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Context;
using WebApp.Dto;
using WebApp.Models;
using Microsoft.EntityFrameworkCore;
using WebApp.Repository_Pattern.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace WebApp.Areas.Management.Controllers
{
    [Area("Management")]
    [Authorize(Policy = "AdminPolicy")]
    public class BookController : Controller
    {
        MyDbContext _db;
        IBookRepository _repoBook;
        IAuthorRepository _repoAuthor;
       
        public BookController(MyDbContext db, IBookRepository repoBook, IAuthorRepository repoAuthor)
        { 
            _db = db; 
            _repoBook = repoBook;
            _repoAuthor = repoAuthor;
           
        }
        public IActionResult BookList()
        {
            List<Book> books = _repoBook.GetBooks(); 
            return View(books); 
        }

        public IActionResult Create()
        {
            List<AuthorDto> authors = _repoAuthor.SelectAuthorDto();
            List<BookTypeDto> bookTypes = _db.BookTypes.Where(x => x.Status != Enums.DataStatus.Deleted).Select(x =>
           new BookTypeDto()
           {
                ID = x.ID,
                Name = x.Name
           }).ToList();

            return View((new Book(),authors,bookTypes)); 
        }
        
        [HttpPost]
        public IActionResult Create([Bind(Prefix = "İtem1")] Book book) 
        {
            if (!ModelState.IsValid) 
            {
                List<AuthorDto> authors = _repoAuthor.SelectAuthorDto();
                List<BookTypeDto> bookTypes = _db.BookTypes.Where(x => x.Status != Enums.DataStatus.Deleted).Select(x =>
               new BookTypeDto()
               {
                   ID = x.ID,
                   Name = x.Name
               }).ToList();

                return View((book, authors, bookTypes));  
            }
            _repoBook.Add(book);
            return RedirectToAction("BookList","Book", new { area="Management"});
        }

    }
}
