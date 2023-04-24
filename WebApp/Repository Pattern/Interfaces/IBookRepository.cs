using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Repository_Pattern.Interfaces
{
   public interface IBookRepository : IRepository<Book>  
    {
        List<Book> GetBooks(); 
    }
}
