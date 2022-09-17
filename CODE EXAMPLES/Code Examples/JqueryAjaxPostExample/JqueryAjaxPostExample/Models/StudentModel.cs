﻿using System.ComponentModel.DataAnnotations;

namespace JqueryAjaxPostExample.Models
{
    public class StudentModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
