//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Kacper_Wiecek_w69860_Programowanie_Obiektowe.LAB3
//{
//    public class Reviewer : Reader
//    {
//        public Reviewer(string firstName, string lastName, int age) : base(firstName, lastName, age)
//        {
//        }

//        public void ViewWithRatings()
//        {
//            Console.WriteLine($"Books reviewed by {FirstName} {LastName}:");
//            var random = new Random();
//            foreach (var book in ReadBooks)
//            {
//                Console.WriteLine($"- {book.Title}: Rating {random.Next(1, 6)}/5");
//            }
//        }
//    }
//}
