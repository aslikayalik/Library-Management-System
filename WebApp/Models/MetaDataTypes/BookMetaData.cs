using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models.MetaDataTypes
{
    public class BookMetaData
    {
        [Required(ErrorMessage = "Zorunlu Alan")]
        [MaxLength(70, ErrorMessage = "Maksimum 70 karakter girebilirsiniz.")]
        public string Name { get; set; }
    }
}
