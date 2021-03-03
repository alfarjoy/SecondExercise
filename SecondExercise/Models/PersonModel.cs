using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SecondExercise.Models
{
    public class PersonModel
    {
        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [StringLength(4)]
        public string Zipcode { get; set; }

        [Required]
        [Range(18, 60)]
        public int Age { get; set; }

        [Required]
        public string Pob { get; set; }

        [Required]
        [StringLength(11)]
        public string Contact { get; set; }

        [Required]
        public string Email { get; set; }


    }
}