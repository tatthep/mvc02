using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc02.Models {
    public class Subject {

        [Key]
        [Required]
        [StringLength(10,MinimumLength =2)]
        public string Code { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Range(1,99)]
        public int Days { get; set; }

        [Range(1,999)]
        public int Hours { get; set; }

        public string InstructorName { get; set; }

        public string Description { get; set; }
        public string CourseOutline { get; set; }

    }
}
