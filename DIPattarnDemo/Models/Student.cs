using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DIPattarnDemo.Models
{
    [Table("Student")]
    public class Student
    {
       
        [Key]
        public int Rollno{ get; set; }
        [Required]
        [Display(Name = "Student Name")]
        public string? Name { get; set; }
        [Display(Name = "Student Percentage")]
        [Required]
        public decimal Percentage { get; set; }
        [Required]
       
        [Display(Name = "Branch Name")]
        public string? Branch { get; set; }

      
    }
}
