using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ErHaSolution.Models
{
    [Table("EmployeeCategory")]
    public class EmployeeCategory
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("Category")]
        [Required(ErrorMessage = "Este é um campo obrigatório!")]
        [MaxLength(60, ErrorMessage = "Este campo deve contar entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve contar entre 3 e 60 caracteres")]
        public string Category { get; set; }



    }
}
