using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lab1
{
    /// <summary>
    /// Фамилия
    /// </summary>
    public class Surname
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string Str { get; set; }
    }
}
