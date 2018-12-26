using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lab1
{
    /// <summary>
    /// Книга 
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Код книги
        /// </summary>
        [Key]
        public long Id { get; set; }
        /// <summary>
        /// Название
        /// </summary>
        [Required]
        public string Str { get; set; }
        /// <summary>
        /// Автор
        /// </summary>
        [Required]
        public long AuthorId { get; set; }
        public virtual Author Author { get; set; }
        /// <summary>
        /// Залоговая стоимость
        /// </summary>
        [Required]
        public decimal CollateralValue { get; set; }
        /// <summary>
        /// Стоимость проката
        /// </summary>
        [Required]
        public decimal RentalPrice { get; set; }
        /// <summary>
        /// Жанр
        /// </summary>
        [Required]
        public long StyleId { get; set; }
        public virtual Style Style { get; set; }
        /// <summary>
        /// Кол-во
        /// </summary>
        [Required]
        public int Count { get; set; }
    }
}
