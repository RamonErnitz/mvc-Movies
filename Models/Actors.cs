using DataAnnotationsExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAK.Models
{
    public class Actor
    {
        public int Id { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }

        [Range(1, 100)]
        public int Age { get; set; }

        [Min(0)]
        public int Salary { get; set; }
    }
}
