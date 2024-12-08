using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kacper_Wiecek_w69860_Programowanie_Obiektowe.LAB2
{
    

    public class Osoba
    {
        private string imie;
        private string nazwisko;
        private int wiek;

        public string Imie
        {
            get => imie;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 2)
                    throw new ArgumentException("Imię musi mieć co najmniej 2 znaki.");
                imie = value;
            }
        }

        public string Nazwisko
        {
            get => nazwisko;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 2)
                    throw new ArgumentException("Nazwisko musi mieć co najmniej 2 znaki.");
                nazwisko = value;
            }
        }

        public int Wiek
        {
            get => wiek;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Wiek musi być liczbą dodatnią.");
                wiek = value;
            }
        }

        public Osoba(string imie, string nazwisko, int wiek)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine($"Imię: {Imie}, Nazwisko: {Nazwisko}, Wiek: {Wiek}");
        }
    }
    public class BankAccount
    {
        private decimal saldo;
        public string Wlasciciel { get; private set; }

        public decimal Saldo => saldo;

        public BankAccount(string wlasciciel, decimal poczatkoweSaldo)
        {
            Wlasciciel = wlasciciel;
            if (poczatkoweSaldo < 0)
                throw new ArgumentException("Saldo początkowe nie może być ujemne.");
            saldo = poczatkoweSaldo;
        }

        public void Wplata(decimal kwota)
        {
            if (kwota <= 0)
                throw new ArgumentException("Kwota wpłaty musi być większa od zera.");
            saldo += kwota;
        }

        public void Wyplata(decimal kwota)
        {
            if (kwota <= 0)
                throw new ArgumentException("Kwota wypłaty musi być większa od zera.");
            if (kwota > saldo)
                throw new InvalidOperationException("Niewystarczające środki na koncie.");
            saldo -= kwota;
        }
    }
    public class Student
    {
        public string Imie { get; private set; }
        public string Nazwisko { get; private set; }
        private readonly List<int> oceny = new List<int>();

        public double SredniaOcen => oceny.Any() ? oceny.Average() : 0;

        public Student(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
        }

        public void DodajOcene(int ocena)
        {
            if (ocena < 1 || ocena > 6)
                throw new ArgumentException("Ocena musi być w zakresie od 1 do 6.");
            oceny.Add(ocena);
        }
    }
    public class Licz
    {
        private int value;

        public Licz(int poczatkowaWartosc)
        {
            value = poczatkowaWartosc;
        }

        public void Dodaj(int liczba)
        {
            value += liczba;
        }

        public void Odejmij(int liczba)
        {
            value -= liczba;
        }

        public void WyswietlStan()
        {
            Console.WriteLine($"Aktualna wartość: {value}");
        }
    }
    public class Sumator
    {
        private int[] liczby;

        public Sumator(int[] liczby)
        {
            this.liczby = liczby ?? throw new ArgumentNullException(nameof(liczby));
        }

        public int Suma()
        {
            return liczby.Sum();
        }

        public int SumaPodziel2()
        {
            return liczby.Where(l => l % 2 == 0).Sum();
        }

        public int IleElementow()
        {
            return liczby.Length;
        }

        public void WypiszElementy()
        {
            Console.WriteLine(string.Join(", ", liczby));
        }

        public void WypiszZakres(int lowIndex, int highIndex)
        {
            for (int i = Math.Max(0, lowIndex); i <= Math.Min(highIndex, liczby.Length - 1); i++)
            {
                Console.Write($"{liczby[i]} ");
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main()
        {
            // Zadanie 1
            var osoba = new Osoba("Jan", "Kowalski", 30);
            osoba.WyswietlInformacje();

            // Zadanie 2
            var konto = new BankAccount("Anna Nowak", 1000);
            konto.Wplata(500);
            konto.Wyplata(200);
            Console.WriteLine($"Saldo: {konto.Saldo}");

            // Zadanie 3
            var student = new Student("Piotr", "Zieliński");
            student.DodajOcene(5);
            student.DodajOcene(4);
            Console.WriteLine($"Średnia ocen: {student.SredniaOcen}");

            // Zadanie 4
            var liczba = new Licz(10);
            liczba.Dodaj(5);
            liczba.Odejmij(3);
            liczba.WyswietlStan();

            // Zadanie 5
            var sumator = new Sumator(new[] { 1, 2, 3, 4, 5, 6 });
            Console.WriteLine($"Suma: {sumator.Suma()}");
            Console.WriteLine($"Suma podzielnych przez 2: {sumator.SumaPodziel2()}");
            Console.WriteLine($"Liczba elementów: {sumator.IleElementow()}");
            sumator.WypiszElementy();
            sumator.WypiszZakres(1, 4);
        }
    }








}
