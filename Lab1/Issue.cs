using System;
using System.ComponentModel.DataAnnotations;

namespace Lab1
{
    /// <summary>
    /// Выдача книги
    /// </summary>
    public class Issue
    {
        [Key]
        public long Id { get; set; }
        /// <summary>
        /// Код книги
        /// </summary>
        [Required]
        public long BookId { get; set; }
        public virtual Book Book { get; set; }
        /// <summary>
        /// Код читателя
        /// </summary>
        [Required]
        public long ReaderId { get; set; }
        public virtual Reader Reader { get; set; }
        /// <summary>
        /// Дата выдачи
        /// </summary>
        [Required]
        public DateTime DateIssue { get; set; }
        /// <summary>
        /// Дата возврата
        /// </summary>
        public DateTime? DateReturn { get; set; }
    }
}
