using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace ErHaSolution.Models
{
    public class Employee
    {
        
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public double Sallary { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime  HiredDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime FiredDate { get; set; }

        public int EmployeeCategoryId { get; set; }
        public EmployeeCategory EmployeeCategory { get; set; }

    }
}
