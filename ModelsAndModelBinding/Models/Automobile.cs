using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelsAndModelBinding.Models
{
    public class Automobile
    {
        /// <summary>
        /// The unique 9 digit ID number for the automobile
        /// </summary>
        public string VinNum { get; set; }

        /// <summary>
        /// The maker of the car Ex. Honda
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        /// Title of the car Ex. Civic
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The year the car was manufactured
        /// </summary>
        public string Year { get; set; }
    }
}