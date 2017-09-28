using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainWpfHarde.Controls_training.BusinessLogic
{
    public class VM
    {
        public List<Book> Books { get; set; } = BookManager.GetBooks();
        public int MyProperty { get; set; }
    }
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string CoverImage { get; set; } = "pack://application:,,,/Controls training/BusinessLogic/BindImages/1.png";

    }

    public class BookManager
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>
            {
                new Book { BookId = 1, Title = "Vulpate", Author = "Futurum", CoverImage = "pack://application:,,,/Controls training/BusinessLogic/BindImages/1.png" },
                new Book { BookId = 2, Title = "Mazim", Author = "Sequiter Que", CoverImage = "BusinessLogic/BindImages/2.png" }, 
                new Book { BookId = 3, Title = "Elit", Author = "Tempor", CoverImage = "BusinessLogic/BindImages/3.png" }, 
                new Book { BookId = 4, Title = "Etiam", Author = "Option", CoverImage = "BusinessLogic/BindImages/4.png" },
                new Book { BookId = 5, Title = "Feugait Eros Libex", Author = "Accumsan", CoverImage = "BusinessLogic/BindImages/5.png" },
                new Book { BookId = 6, Title = "Nonummy Erat", Author = "Legunt Xaepius", CoverImage = "/TrainWpfHarde;component/Controls training/BusinessLogic/BindImages/6.png" },
                new Book { BookId = 7, Title = "Nostrud", Author = "Eleifend", CoverImage = "/TrainWpfHarde;component/Controls training/BusinessLogic/BindImages/7.png" },
                new Book { BookId = 8, Title = "Per Modo", Author = "Vero Tation", CoverImage = "/TrainWpfHarde;component/Controls training/BusinessLogic/BindImages/8.png" },
                new Book { BookId = 9, Title = "Suscipit Ad", Author = "Jack Tibbles", CoverImage = "/TrainWpfHarde;component/Controls training/BusinessLogic/BindImages/9.png" },
                new Book { BookId = 10, Title = "Decima", Author = "Tuffy Tibbles", CoverImage = "/TrainWpfHarde;component/Controls training/BusinessLogic/BindImages/10.png" },
                new Book { BookId = 11, Title = "Erat", Author = "Volupat", CoverImage = "/TrainWpfHarde;component/Controls training/BusinessLogic/BindImages/11.png" },
                new Book { BookId = 12, Title = "Consequat", Author = "Est Possim", CoverImage = "/TrainWpfHarde;component/Controls training/BusinessLogic/BindImages/12.png" },
                new Book { BookId = 13, Title = "Aliquip", Author = "Magna", CoverImage = "/TrainWpfHarde;component/Controls training/BusinessLogic/BindImages/13.png" }
            };

            return books;
        }
    }
}
