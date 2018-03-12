using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace College.Models
{
    public class Attendance
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Month")]
        public byte MonthId { get; set; }

        public Month Month { get; set; }

        [Required]
        [Display(Name = "Student")]
        public int StudentId { get; set; }

        public Student Student { get; set; }

        [Required]
        public byte AttendanceInPercent { get; set; }
    }
}