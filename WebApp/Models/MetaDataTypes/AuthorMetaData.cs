using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.MetaDataTypes
{
    public class AuthorMetaData
    {
        
        [Required(ErrorMessage = "Zorunlu Alan")]
        [MaxLength(15, ErrorMessage = "Maksimum 15 karakter girebilirsiniz.")]
        public string FirstName { get; set; }
      
    }
}
