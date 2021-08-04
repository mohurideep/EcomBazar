using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practise_Demo.Models
{
    public class Asset
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Asset Name is required")]
        //[MaxLength(30,ErrorMessage ="name cannot be more than 30 character")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Asset Description required")]
        public string Description { get; set; }
        [Required]
        [Remote("CheckTagUniquness","Asset", AdditionalFields ="Id")]
        public string TagNumber { get; set; }
    }
}
