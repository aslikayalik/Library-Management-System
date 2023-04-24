using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models.MetaDataTypes;

namespace WebApp.Models
{
    [ModelMetadataType(typeof(AuthorMetaData))]
    public class Author : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // Relational Property
        public List<Book> Books { get; set; }
    }
}
