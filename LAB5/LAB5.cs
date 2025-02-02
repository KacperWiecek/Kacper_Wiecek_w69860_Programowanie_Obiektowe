//using System;
//using System.Collections.Generic;

//#region Zadanie 1: Kalkulator operacji matematycznych

//public enum Operacja
//{
//    Dodawanie,
//    Odejmowanie,
//    Mnożenie,
//    Dzielenie
//}

//public class Kalkulator
//{
//    private List<double> historiaWyników = new List<double>();

//    public double WykonajOperacje(double liczba1, double liczba2, Operacja operacja)
//    {
//        double wynik = 0;

//        try
//        {
//            switch (operacja)
//            {
//                case Operacja.Dodawanie:
//                    wynik = liczba1 + liczba2;
//                    break;
//                case Operacja.Odejmowanie:
//                    wynik = liczba1 - liczba2;
//                    break;
//                case Operacja.Mnożenie:
//                    wynik = liczba1 * liczba2;
//                    break;
//                case Operacja.Dzielenie:
//                    if (liczba2 == 0)
//                        throw new DivideByZeroException();
//                    wynik = liczba1 / liczba2;
//                    break;
//                default:
//                    throw new ArgumentOutOfRangeException();
//            }
//            historiaWyników.Add(wynik);
//        }
//        catch (DivideByZeroException)
//        {
//            Console.WriteLine("Błąd: Nie można dzielić przez zero.");
//        }

//        return wynik;
//    }

//    public void PokażHistorieWyników()
//    {
//        Console.WriteLine("Historia wyników:");
//        foreach (var wynik in historiaWyników)
//        {
//            Console.WriteLine(wynik);
//        }
//    }
//}

//#endregion

//#region Zadanie 2: Zarządzanie zamówieniami w sklepie

//public enum StatusZamowienia
//{
//    Oczekujące,
//    Przyjęte,
//    Zrealizowane,
//    Anulowane
//}

//public class Sklep
//{
//    private Dictionary<int, (List<string> produkty, StatusZamowienia status)> zamowienia = new Dictionary<int, (List<string>, StatusZamowienia)>();

//    public void DodajZamowienie(int numerZamowienia, List<string> produkty)
//    {
//        zamowienia[numerZamowienia] = (produkty, StatusZamowienia.Oczekujące);
//    }

//    public void ZmienStatusZamowienia(int numerZamowienia, StatusZamowienia nowyStatus)
//    {
//        try
//        {
//            if (!zamowienia.ContainsKey(numerZamowienia))
//                throw new KeyNotFoundException();

//            var aktualnyStatus = zamowienia[numerZamowienia].status;

//            if (aktualnyStatus == nowyStatus)
//                throw new ArgumentException("Nie można zmienić statusu na ten sam.");

//            zamowienia[numerZamowienia] = (zamowienia[numerZamowienia].produkty, nowyStatus);
//        }
//        catch (KeyNotFoundException)
//        {
//            Console.WriteLine($"Błąd: Zamówienie o numerze {numerZamowienia} nie istnieje.");
//        }
//        catch (ArgumentException ex)
//        {
//            Console.WriteLine($"Błąd: {ex.Message}");
//        }
//    }

//    public void WyswietlZamowienia()
//    {
//        foreach (var zamowienie in zamowienia)
//        {
//            Console.WriteLine($"Numer zamówienia: {zamowienie.Key}, Status: {zamowienie.Value.status}, Produkty: {string.Join(", ", zamowienie.Value.produkty)}");
//        }
//    }
//}

//#endregion

//#region Zadanie 3: Gra w zgadywanie kolorów

//public enum Kolor
//{
//    Czerwony,
//    Niebieski,
//    Zielony,
//    Żółty,
//    Fioletowy
//}

//public class GraKolory
//{
//    private List<Kolor> listaKolorów = new List<Kolor> { Kolor.Czerwony, Kolor.Niebieski, Kolor.Zielony, Kolor.Żółty, Kolor.Fioletowy };
//    private Kolor wylosowanyKolor;

//    public GraKolory()
//    {
//        Random random = new Random();
//        wylosowanyKolor = listaKolorów[random.Next(listaKolorów.Count)];
//    }

//    public void RozpocznijGre()
//    {
//        Console.WriteLine("Zgadnij wylosowany kolor (Czerwony, Niebieski, Zielony, Żółty, Fioletowy):");

//        bool zgadnieto = false;

//        while (!zgadnieto)
//        {
//            try
//            {
//                string input = Console.ReadLine();
//                if (!Enum.TryParse(input, true, out Kolor zgadywanyKolor) || !listaKolorów.Contains(zgadywanyKolor))
//                    throw new ArgumentException("Wprowadzono nieprawidłowy kolor. Spróbuj ponownie.");

//                if (zgadywanyKolor == wylosowanyKolor)
//                {
//                    Console.WriteLine("Gratulacje! Odgadłeś kolor.");
//                    zgadnieto = true;
//                }
//                else
//                {
//                    Console.WriteLine("Nieprawidłowy kolor. Spróbuj ponownie.");
//                }
//            }
//            catch (ArgumentException ex)
//            {
//                Console.WriteLine($"Błąd: {ex.Message}");
//            }
//        }
//    }
//}

//#endregion

//public class Program
//{
//    public static void Main(string[] args)
//    {
        
//        Console.WriteLine("Zadanie 1: Kalkulator");
//        Kalkulator kalkulator = new Kalkulator();
//        kalkulator.WykonajOperacje(10, 5, Operacja.Dodawanie);
//        kalkulator.WykonajOperacje(10, 5, Operacja.Dzielenie);
//        kalkulator.PokażHistorieWyników();

        
//        Console.WriteLine("\nZadanie 2: Zarządzanie zamówieniami");
//        Sklep sklep = new Sklep();
//        sklep.DodajZamowienie(1, new List<string> { "Mleko", "Chleb" });
//        sklep.DodajZamowienie(2, new List<string> { "Jabłka", "Banany" });
//        sklep.WyswietlZamowienia();
//        sklep.ZmienStatusZamowienia(1, StatusZamowienia.Przyjęte);
//        sklep.WyswietlZamowienia();

        
//        Console.WriteLine("\nZadanie 3: Gra w zgadywanie kolorów");
//        GraKolory graKolory = new GraKolory();
//        graKolory.RozpocznijGre();
//    }
//}
