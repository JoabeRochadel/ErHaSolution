using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace ErHaSolution.Models
{
    public class Employee
    {
        /*
         * id ok 
         * name
         * Birth Date
         * Address
         * Gender
         * Sallary
         * Hired Date
         * Fired date
         * Employee Category
         */

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public double Sallary { get; set; }

        [Required]
        public DateTime HiredDate { get; set; }

        public DateTime FiredDate { get; set; }

        [Required]
        public EmployeeCategory EmployeeCategory { get; set; }


        //employee category



    }
}
