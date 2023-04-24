using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models.MetaDataTypes;

namespace WebApp.Models
{
    [ModelMetadataType(typeof(BookTypeMetaData))]
    public class BookType : BaseEntity
    {
        public string Name { get; set; }

        // Relational Property
        public List<Book> Books { get; set; }
    }
}
