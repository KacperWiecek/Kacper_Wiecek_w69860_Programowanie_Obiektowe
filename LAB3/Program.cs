//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection.PortableExecutable;
//using System.Text;
//using System.Threading.Tasks;

//namespace Kacper_Wiecek_w69860_Programowanie_Obiektowe.LAB3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var author1 = new Person("John", "Doe", 45);
//            var author2 = new Person("Jane", "Smith", 38);

//            var book1 = new AdventureBook("Adventure in the Mountains", author1, new DateTime(2020, 5, 20), "Mountains");
//            var book2 = new DocumentaryBook("History of the World", author2, new DateTime(2018, 10, 15), "World History");

//            var reader1 = new Reader("Alice", "Johnson", 30);
//            reader1.AddBook(book1);
//            reader1.AddBook(book2);

//            var reviewer1 = new Reviewer("Bob", "Williams", 35);
//            reviewer1.AddBook(book1);
//            reviewer1.AddBook(book2);

//            var people = new List<Person> { reader1, reviewer1 };

//            foreach (var person in people)
//            {
//                person.View();
//            }
//        }
//    }

//}
