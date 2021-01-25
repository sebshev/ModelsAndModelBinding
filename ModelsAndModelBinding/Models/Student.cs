using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelsAndModelBinding.Models
{
    public class Student
    {
        /// <summary>
        /// The unique 9 digit ID number for the student
        /// </summary>
        public int StudentId { get; set; }

        /// <summary>
        /// The students legal first and last name
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Student email for student (ends with @cptc.edu )
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The birthdate of the student (time is ignored)
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// The Home phone number of the student
        /// </summary>
        public string PhoneNumber { get; set; }
    }
}
