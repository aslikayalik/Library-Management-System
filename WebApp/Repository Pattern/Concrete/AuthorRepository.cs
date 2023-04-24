using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Context;
using WebApp.Dto;
using WebApp.Models;
using WebApp.Repository_Pattern.Base;
using WebApp.Repository_Pattern.Interfaces;

namespace WebApp.Repository_Pattern.Concrete
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(MyDbContext db):base(db)
        {

        }
        public List<AuthorDto> SelectAuthorDto()
        {
            return table.Where(x => x.Status != Enums.DataStatus.Deleted).Select(x =>
            new AuthorDto()
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                ID = x.ID
            }).ToList();
        }
    }
}
