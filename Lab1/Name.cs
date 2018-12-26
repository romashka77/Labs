using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lab1
{
    /// <summary>
    /// Имя
    /// </summary>
    public class Name
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string Str { get; set; }
    }
}
