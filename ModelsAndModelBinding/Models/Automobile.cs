using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModelsAndModelBinding.Models
{
    public class Automobile
    {
        /// <summary>
        /// The unique 9 digit ID number for the automobile
        /// </summary>
        [Display(Name = "VIN Number")]
        [Required]
        public string VinNum { get; set; }

        /// <summary>
        /// The maker of the car Ex. Honda
        /// </summary>
        [Display(Name = "Make")]
        [Required]
        public string Make { get; set; }

        /// <summary>
        /// Title of the car Ex. Civic
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// The year the car was manufactured
        /// </summary>
        [Required]
        public string Year { get; set; }
    }
}