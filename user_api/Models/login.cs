using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace user_api.Models
{
    public class login
    {
        [Required]
        public string irisData { get; set; }
    }
}
