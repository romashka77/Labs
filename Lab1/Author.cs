using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lab1
{
    /// <summary>
    /// Автор
    /// </summary>
    public class Author
    {
        /// <summary>
        /// Код автора
        /// </summary>
        [Key]
        public long Id { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        [Required]
        public long SurnameId { get; set; }
        public virtual Surname Surname { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        [Required]
        public long NameId { get; set; }
        public virtual Name Name { get; set; }
        /// <summary>
        /// Отчество
        /// </summary>
        public long PatronymicId { get; set; }
        public virtual Patronymic Patronymic { get; set; }
    }
}
