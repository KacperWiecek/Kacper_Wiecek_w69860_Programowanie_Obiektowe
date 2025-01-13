//using System;
//using System.Collections.Generic;
//using System.Linq;

//#region Zadanie 1: Kształty 

//public class Ksztalt
//{
//    public int X { get; set; }
//    public int Y { get; set; }
//    public int Wysokosc { get; set; }
//    public int Szerokosc { get; set; }

//    public virtual void Rysuj()
//    {
//        Console.WriteLine("Rysuję kształt.");
//    }
//}

//public class Prostokat : Ksztalt
//{
//    public override void Rysuj()
//    {
//        Console.WriteLine("Rysuję prostokąt.");
//    }
//}

//public class Trojkat : Ksztalt
//{
//    public override void Rysuj()
//    {
//        Console.WriteLine("Rysuję trójkąt.");
//    }
//}

//public class Kolo : Ksztalt
//{
//    public override void Rysuj()
//    {
//        Console.WriteLine("Rysuję koło.");
//    }
//}

//#endregion

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Zadanie 1: Kształty");

//        List<Ksztalt> ksztalty = new List<Ksztalt>
//        {
//            new Prostokat(),
//            new Trojkat(),
//            new Kolo()
//        };

//        foreach (var ksztalt in ksztalty)
//        {
//            ksztalt.Rysuj();
//        }
//    }
//}


//#endregion

//#region Zadanie 2: Polimorfizm i klasy Osoba, Uczen, Nauczyciel

//public abstract class Osoba
//{
//    public string Imie { get; set; }
//    public string Nazwisko { get; set; }
//    public string Pesel { get; set; }

//    public abstract void SetFirstName(string imie);
//    public abstract void SetLastName(string nazwisko);
//    public abstract void SetPesel(string pesel);

//    public int GetAge()
//    {
//        int year = int.Parse(Pesel.Substring(0, 2));
//        int month = int.Parse(Pesel.Substring(2, 2));
//        year += (month > 20) ? 2000 : 1900;
//        return DateTime.Now.Year - year;
//    }

//    public string GetGender()
//    {
//        int genderDigit = int.Parse(Pesel[9].ToString());
//        return genderDigit % 2 == 0 ? "Female" : "Male";
//    }

//    public abstract string GetEducationInfo();
//    public string GetFullName() => $"{Imie} {Nazwisko}";
//    public abstract bool CanGoAloneToHome();
//}

//public class Uczen : Osoba
//{
//    public string Szkola { get; set; }
//    public bool MozeSamWracacDoDomu { get; set; }

//    public override void SetFirstName(string imie) => Imie = imie;
//    public override void SetLastName(string nazwisko) => Nazwisko = nazwisko;
//    public override void SetPesel(string pesel) => Pesel = pesel;

//    public void SetSchool(string szkola) => Szkola = szkola;
//    public void ChangeSchool(string szkola) => Szkola = szkola;
//    public void SetCanGoHomeAlone(bool canGo) => MozeSamWracacDoDomu = canGo;

//    public override string GetEducationInfo() => $"Uczeń w szkole {Szkola}";

//    public override bool CanGoAloneToHome()
//    {
//        return GetAge() >= 12 || MozeSamWracacDoDomu;
//    }
//}

//public class Nauczyciel : Uczen
//{
//    public string TytulNaukowy { get; set; }
//    public List<Uczen> PodwladniUczniowie { get; set; } = new List<Uczen>();

//    public void WhichStudentCanGoHomeAlone(DateTime dateToCheck)
//    {
//        foreach (var uczen in PodwladniUczniowie)
//        {
//            if (uczen.CanGoAloneToHome())
//            {
//                Console.WriteLine(uczen.GetFullName());
//            }
//        }
//    }
//}

//#endregion

//#region Zadanie 3: Interfejs IOsoba, rozszerzenia i klasy Student

//public interface IOsoba
//{
//    string Imie { get; set; }
//    string Nazwisko { get; set; }

//    string ZwrocPelnaNazwe();
//}

//public class OsobaImplementacja : IOsoba
//{
//    public string Imie { get; set; }
//    public string Nazwisko { get; set; }

//    public string ZwrocPelnaNazwe() => $"{Imie} {Nazwisko}";
//}

//public static class IOsobaExtensions
//{
//    public static void WypiszOsoby(this List<IOsoba> osoby)
//    {
//        foreach (var osoba in osoby)
//        {
//            Console.WriteLine(osoba.ZwrocPelnaNazwe());
//        }
//    }

//    public static void PosortujOsobyPoNazwisku(this List<IOsoba> osoby)
//    {
//        osoby.Sort((a, b) => string.Compare(a.Nazwisko, b.Nazwisko, StringComparison.Ordinal));
//    }
//}

//public interface IStudent : IOsoba
//{
//    string Uczelnia { get; set; }
//    string Kierunek { get; set; }
//    int Rok { get; set; }
//    int Semestr { get; set; }
//}

//public class Student : IStudent
//{
//    public string Imie { get; set; }
//    public string Nazwisko { get; set; }
//    public string Uczelnia { get; set; }
//    public string Kierunek { get; set; }
//    public int Rok { get; set; }
//    public int Semestr { get; set; }

//    public string ZwrocPelnaNazwe() => $"{Imie} {Nazwisko}";

//    public virtual string WypiszPelnaNazweIUczelnie()
//        => $"{Imie} {Nazwisko} – {Kierunek}, Rok {Rok}, Uczelnia: {Uczelnia}";
//}

//public class StudentWSIiZ : Student
//{
//    public override string WypiszPelnaNazweIUczelnie()
//        => $"{Imie} {Nazwisko} – {Kierunek} {Rok} WSIiZ";
//}

//#endregion

//#region Program główny

//public class Program
//{
//    public static void Main(string[] args)
//    {
   
//        Console.WriteLine("Zadanie 1:");
//        List<Shape> shapes = new List<Shape>
//        {
//            new Rectangle(),
//            new Triangle(),
//            new Circle()
//        };

//        foreach (var shape in shapes)
//        {
//            shape.Draw();
//        }

 
//        Console.WriteLine("\nZadanie 2:");
//        var nauczyciel = new Nauczyciel
//        {
//            Imie = "Anna",
//            Nazwisko = "Nowak",
//            TytulNaukowy = "Dr",
//            PodwladniUczniowie = new List<Uczen>
//            {
//                new Uczen { Imie = "Jan", Nazwisko = "Kowalski", Pesel = "06010112345", Szkola = "SP1", MozeSamWracacDoDomu = true },
//                new Uczen { Imie = "Kasia", Nazwisko = "Nowak", Pesel = "14020398765", Szkola = "SP1", MozeSamWracacDoDomu = false }
//            }
//        };

//        Console.WriteLine("Uczniowie, którzy mogą wracać do domu:");
//        nauczyciel.WhichStudentCanGoHomeAlone(DateTime.Now);

        
//        Console.WriteLine("\nZadanie 3:");
//        List<IOsoba> osoby = new List<IOsoba>
//        {
//            new OsobaImplementacja { Imie = "Jan", Nazwisko = "Kowalski" },
//            new OsobaImplementacja { Imie = "Anna", Nazwisko = "Nowak" },
//            new OsobaImplementacja { Imie = "Piotr", Nazwisko = "Zieliński" }
//        };

//        osoby.WypiszOsoby();
//        osoby.PosortujOsobyPoNazwisku();
//        Console.WriteLine("\nPosortowane osoby:");
//        osoby.WypiszOsoby();

//        List<Student> studenci = new List<Student>
//        {
//            new StudentWSIiZ { Imie = "Adam", Nazwisko = "Malinowski", Kierunek = "Informatyka", Rok = 2023 },
//            new StudentWSIiZ { Imie = "Marta", Nazwisko = "Wiśniewska", Kierunek = "Ekonomia", Rok = 2022 }
//        };

//        Console.WriteLine("\nStudenci WSIiZ:");
//        foreach (var student in studenci)
//        {
//            Console.WriteLine(student.WypiszPelnaNazweIUczelnie());
//        }
//    }
//}

//#endregion
