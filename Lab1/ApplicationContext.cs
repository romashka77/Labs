using Microsoft.EntityFrameworkCore;
//using MySQL.Data.EntityFrameworkCore.Extensions;

namespace Lab1
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Issue> Issues { get; set; }
        public DbSet<Name> Names { get; set; }
        public DbSet<Patronymic> Patronymics { get; set; }
        public DbSet<Reader> Readers { get; set; }
        public DbSet<Style> Styles { get; set; }
        public DbSet<Surname> Surnames { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=127.0.0.1;UserId=root;database=lab1;");
        }
    }
}
