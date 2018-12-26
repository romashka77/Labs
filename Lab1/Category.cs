using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lab1
{
    /// <summary>
    /// Категория читателя
    /// </summary>
    public class Category
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string Str { get; set; }
        /// <summary>
        /// Скидка
        /// </summary>
        [Required]
        public float Discount { get; set; }
    }
}
