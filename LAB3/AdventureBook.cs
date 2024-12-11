using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kacper_Wiecek_w69860_Programowanie_Obiektowe.LAB3
{
    public class AdventureBook : Book
    {
        public string Setting { get; set; }

        public AdventureBook(string title, Person author, DateTime releaseDate, string setting)
            : base(title, author, releaseDate)
        {
            Setting = setting;
        }

        public override void View()
        {
            base.View();
            Console.WriteLine($"Setting: {Setting}");
        }
    }
}
