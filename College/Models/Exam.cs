using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace College.Models
{
    public class Exam
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string name { get; set; }

        [Required]
        [Display(Name = "Course")]
        public byte CourseId { get; set; }

        public Course Course { get; set; }

        [Required]
        public DateTime DateOfExam { get; set; }
    }
}