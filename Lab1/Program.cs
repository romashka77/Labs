using System;
using System.Linq;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureCreated();
                Surname surname = new Surname { Str = "Иванов" };
                db.Surnames.Add(surname);
                Name name = new Name { Str = "Иван" };
                db.Names.Add(name);
                Patronymic patronymic = new Patronymic { Str = "Иванович" };
                db.Patronymics.Add(patronymic);
                Category category = new Category { Str = "Прилежный читатель", Discount = 1 };
                db.Categorys.Add(category);
                Reader reader = new Reader { Surname = surname, Name = name, Patronymic = patronymic, Address = "Тамбов", Phone = "123456", Category = category };
                db.Readers.Add(reader);
                Author author = new Author { Name = new Name { Str = "Александр" }, Surname = new Surname { Str = "Пушкин" }, Patronymic = new Patronymic { Str = "Сергеевич" } };
                db.Authors.Add(author);
                Style style = new Style { Str = "Литература" };
                db.Styles.Add(style);
                Book book = new Book { Author = author, Style = style, Str = "Сказка о царе Салтане", Count = 10, CollateralValue = 100, RentalPrice = 10, };
                db.Books.Add(book);
                Issue issue = new Issue { Book = book, DateIssue = DateTime.Now, Reader = reader };
                db.Issues.Add(issue);


                surname = new Surname { Str = "Петров" };
                db.Surnames.Add(surname);
                name = new Name { Str = "Петр" };
                db.Names.Add(name);
                patronymic = new Patronymic { Str = "Петрович" };
                db.Patronymics.Add(patronymic);
                category = new Category { Str = "Правонарушитель", Discount = 2 };
                db.Categorys.Add(category);
                reader = new Reader { Surname = surname, Name = name, Patronymic = patronymic, Address = "Тамбов", Phone = "654321", Category = category };
                db.Readers.Add(reader);

                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");

                var t = db.Issues.ToList();
                Console.WriteLine("Список объектов:");
                foreach (Issue item in t)
                {
                    Console.WriteLine($"{item.Id}.{item.Book.Author.Surname.Str} - {item.Book.Str}");
                }
            }
            Console.Read();
        }
    }
}
