using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Context;
using WebApp.Models;
using WebApp.Repository_Pattern.Base;
using WebApp.Repository_Pattern.Interfaces;

namespace WebApp.Repository_Pattern.Concrete
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(MyDbContext db) : base(db)
        {

        }
        public List<Book> GetBooks()
        {
            return table.Where(b => b.Status != Enums.DataStatus.Deleted).Include(x => x.Author).Include(x =>
            x.BookType).ToList(); 
        }
    } 
}
