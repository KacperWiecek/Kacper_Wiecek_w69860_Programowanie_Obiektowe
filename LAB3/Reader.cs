//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Kacper_Wiecek_w69860_Programowanie_Obiektowe.LAB3
//{
//    public class Reader : Person
//    {
//        protected List<Book> ReadBooks { get; set; } = new List<Book>(); // Zmieniono na protected

//        public Reader(string firstName, string lastName, int age) : base(firstName, lastName, age)
//        {
//        }

//        public void AddBook(Book book)
//        {
//            ReadBooks.Add(book);
//        }

//        public void ViewBooks()
//        {
//            Console.WriteLine($"Books read by {FirstName} {LastName}:");
//            foreach (var book in ReadBooks)
//            {
//                Console.WriteLine($"- {book.Title}");
//            }
//        }

//        public override void View()
//        {
//            base.View();
//            ViewBooks();
//        }
//    }
//}
