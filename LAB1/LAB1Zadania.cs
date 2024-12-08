//using System;

//namespace Kacper_Wiecek_w69860_Programowanie_Obiektowe.LAB1
//{
//    class LAB1
//    {
//        static void Main()
//        {
//            while (true)
//            {
//                Console.WriteLine("\n==== MENU GŁÓWNE ====");
//                Console.WriteLine("1. Oblicz wyróżnik delta i pierwiastki trójmianu kwadratowego");
//                Console.WriteLine("2. Kalkulator matematyczny");
//                Console.WriteLine("3. Operacje na tablicy (10 liczb)");
//                Console.WriteLine("4. Operacje matematyczne na tablicy (10 liczb)");
//                Console.WriteLine("5. Wyświetlanie liczb od 20 do 0 z pominięciem");
//                Console.WriteLine("6. Nieskończona pętla z przerwaniem");
//                Console.WriteLine("7. Sortowanie liczb");
//                Console.WriteLine("0. Wyjście");
//                Console.Write("Wybierz opcję: ");
//                int wybor = int.Parse(Console.ReadLine());

//                switch (wybor)
//                {
//                    case 0:
//                        Console.WriteLine("Koniec programu.");
//                        return;
//                    case 1:
//                        Zadanie1();
//                        break;
//                    case 2:
//                        Zadanie2();
//                        break;
//                    case 3:
//                        Zadanie3();
//                        break;
//                    case 4:
//                        Zadanie4();
//                        break;
//                    case 5:
//                        Zadanie5();
//                        break;
//                    case 6:
//                        Zadanie6();
//                        break;
//                    case 7:
//                        Zadanie7();
//                        break;

//                    default:
//                        Console.WriteLine("Niepoprawny wybór.");
//                        break;
//                }
//            }
//        }

//        static void Zadanie1()
//        {
//            Console.WriteLine("Podaj wartości a, b, c:");
//            double a = double.Parse(Console.ReadLine());
//            double b = double.Parse(Console.ReadLine());
//            double c = double.Parse(Console.ReadLine());

//            double delta = b * b - 4 * a * c;
//            Console.WriteLine($"Delta: {delta}");

//            if (delta > 0)
//            {
//                double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
//                double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
//                Console.WriteLine($"Pierwiastki: x1 = {x1}, x2 = {x2}");
//            }
//            else if (delta == 0)
//            {
//                double x = -b / (2 * a);
//                Console.WriteLine($"Pierwiastek podwójny: x = {x}");
//            }
//            else
//            {
//                Console.WriteLine("Brak pierwiastków rzeczywistych.");
//            }
//        }

//        static void Zadanie2()
//        {
//            while (true)
//            {
//                Console.WriteLine("\nKalkulator:");
//                Console.WriteLine("1. Dodawanie");
//                Console.WriteLine("2. Odejmowanie");
//                Console.WriteLine("3. Mnożenie");
//                Console.WriteLine("4. Dzielenie");
//                Console.WriteLine("5. Potęgowanie");
//                Console.WriteLine("6. Pierwiastkowanie");
//                Console.WriteLine("7. Funkcje trygonometryczne");
//                Console.WriteLine("0. Wyjście");
//                Console.Write("Wybierz opcję: ");
//                int wybor = int.Parse(Console.ReadLine());

//                if (wybor == 0) break;

//                switch (wybor)
//                {
//                    case 1:
//                        Console.WriteLine("Podaj dwie liczby:");
//                        double a = double.Parse(Console.ReadLine());
//                        double b = double.Parse(Console.ReadLine());
//                        Console.WriteLine($"Wynik: {a + b}");
//                        break;
//                    case 2:
//                        Console.WriteLine("Podaj dwie liczby:");
//                        a = double.Parse(Console.ReadLine());
//                        b = double.Parse(Console.ReadLine());
//                        Console.WriteLine($"Wynik: {a - b}");
//                        break;
//                    case 3:
//                        Console.WriteLine("Podaj dwie liczby:");
//                        a = double.Parse(Console.ReadLine());
//                        b = double.Parse(Console.ReadLine());
//                        Console.WriteLine($"Wynik: {a * b}");
//                        break;
//                    case 4:
//                        Console.WriteLine("Podaj dwie liczby:");
//                        a = double.Parse(Console.ReadLine());
//                        b = double.Parse(Console.ReadLine());
//                        if (b != 0)
//                            Console.WriteLine($"Wynik: {a / b}");
//                        else
//                            Console.WriteLine("Błąd: dzielenie przez zero!");
//                        break;
//                    case 5:
//                        Console.WriteLine("Podaj podstawę i wykładnik:");
//                        a = double.Parse(Console.ReadLine());
//                        b = double.Parse(Console.ReadLine());
//                        Console.WriteLine($"Wynik: {Math.Pow(a, b)}");
//                        break;
//                    case 6:
//                        Console.WriteLine("Podaj liczbę:");
//                        a = double.Parse(Console.ReadLine());
//                        if (a >= 0)
//                            Console.WriteLine($"Wynik: {Math.Sqrt(a)}");
//                        else
//                            Console.WriteLine("Błąd: liczba ujemna!");
//                        break;
//                    case 7:
//                        Console.WriteLine("Podaj kąt w radianach:");
//                        a = double.Parse(Console.ReadLine());
//                        Console.WriteLine($"Sin: {Math.Sin(a)}, Cos: {Math.Cos(a)}, Tan: {Math.Tan(a)}");
//                        break;
//                    default:
//                        Console.WriteLine("Niepoprawny wybór.");
//                        break;
//                }
//            }
//        }

//        static void Zadanie3()
//        {
//            double[] tablica = new double[10];
//            Console.WriteLine("Wprowadź 10 liczb:");

//            for (int i = 0; i < 10; i++)
//                tablica[i] = double.Parse(Console.ReadLine());

//            do
//            {
//                Console.WriteLine("Menu:");
//                Console.WriteLine("1. Wyświetl od początku do końca");
//                Console.WriteLine("2. Wyświetl od końca do początku");
//                Console.WriteLine("3. Wyświetl elementy o nieparzystych indeksach");
//                Console.WriteLine("4. Wyświetl elementy o parzystych indeksach");
//                Console.WriteLine("0. Powrót do menu głównego");

//                int wybor = int.Parse(Console.ReadLine());

//                if (wybor == 0) break;

//                if (wybor == 1)
//                    for (int i = 0; i < tablica.Length; i++)
//                        Console.WriteLine(tablica[i]);
//                else if (wybor == 2)
//                    for (int i = tablica.Length - 1; i >= 0; i--)
//                        Console.WriteLine(tablica[i]);
//                else if (wybor == 3)
//                    for (int i = 1; i < tablica.Length; i += 2)
//                        Console.WriteLine(tablica[i]);
//                else if (wybor == 4)
//                    for (int i = 0; i < tablica.Length; i += 2)
//                        Console.WriteLine(tablica[i]);
//                else
//                    Console.WriteLine("Niepoprawny wybór.");
//            } while (true);
//        }
        
//        static void Zadanie4()
//        {
//            double[] liczby = new double[10];
//            Console.WriteLine("Wprowadź 10 liczb:");

//            for (int i = 0; i < liczby.Length; i++)
//                liczby[i] = double.Parse(Console.ReadLine());

//            double suma = 0, iloczyn = 1, min = liczby[0], max = liczby[0];

//            foreach (double liczba in liczby)
//            {
//                suma += liczba;
//                iloczyn *= liczba;
//                if (liczba < min) min = liczba;
//                if (liczba > max) max = liczba;
//            }

//            double srednia = suma / liczby.Length;

//            Console.WriteLine($"Suma: {suma}, Iloczyn: {iloczyn}, Średnia: {srednia}, Min: {min}, Max: {max}");
//        }

//        static void Zadanie5()
//        {
//            for (int i = 20; i >= 0; i--)
//            {
//                if (i == 2 || i == 6 || i == 9 || i == 15 || i == 19)
//                    continue;

//                Console.WriteLine(i);
//            }
//        }

//        static void Zadanie6()
//        {
//            Console.WriteLine("Wprowadzaj liczby całkowite. Program zakończy działanie po wpisaniu liczby mniejszej od zera.");

//            while (true) 
//            {
//                Console.Write("Podaj liczbę: ");
//                int liczba = int.Parse(Console.ReadLine());

//                if (liczba < 0) 
//                {
//                    Console.WriteLine("Wprowadzono liczbę mniejszą od zera. Koniec programu.");
//                    break;
//                }

//                Console.WriteLine($"Wprowadzona liczba to: {liczba}");
//            }
//        }

//        static void Zadanie7()
//        {
//            Console.WriteLine("Ile liczb chcesz wprowadzić?");
//            int n = int.Parse(Console.ReadLine());
//            int[] liczby = new int[n];

//            Console.WriteLine($"Wprowadź {n} liczb:");
//            for (int i = 0; i < n; i++)
//                liczby[i] = int.Parse(Console.ReadLine());


//            for (int i = 0; i < liczby.Length - 1; i++)
//            {
//                for (int j = 0; j < liczby.Length - i - 1; j++)
//                {
//                    if (liczby[j] > liczby[j + 1])
//                    {
//                        int temp = liczby[j];
//                        liczby[j] = liczby[j + 1];
//                        liczby[j + 1] = temp;
//                    }
//                }
//            }

//            Console.WriteLine("Posortowane liczby:");
//            foreach (int liczba in liczby)
//                Console.WriteLine(liczba);
//        }


//    }
//}       
