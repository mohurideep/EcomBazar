using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practise_Demo.Models
{
    public class Employee
    {
        public int Emp_id { get; set; }
        [Required(ErrorMessage ="Name cannot be empty")]
        [Remote("CheckNameUnique","Employee")]
        public string Emp_name { get; set; }
        [Remote ("PinCodeValid","Employee")]
        public string Pincode { get; set; }
    }
}
