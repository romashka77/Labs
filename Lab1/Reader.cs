using System.ComponentModel.DataAnnotations;

namespace Lab1
{
    /// <summary>
    /// Читатель
    /// </summary>
    public class Reader
    {
        /// <summary>
        /// Код читателя
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
        /// <summary>
        /// Адрес
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Телефон
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// Категория читателя
        /// </summary>
        [Required]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
