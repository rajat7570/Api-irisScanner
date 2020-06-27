using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace user_api.Models
{
    public class Employees
    {
        [Key]
        public long EmpId { get; set; }
        [Required]
        [Index(IsUnique = true)]
        public string iris { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public long Mob { get; set; }

    }
}
