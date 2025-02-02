//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text.Json;
//using static Task4;


//class Task1
//{
//    public static void SaveAlbumNumber(string fileName, string albumNumber)
//    {
//        File.WriteAllText(fileName, albumNumber);
//        Console.WriteLine("Numer albumu zapisany do pliku.");
//    }
//}


//class Task2
//{
//    public static void ReadFileContent(string fileName)
//    {
//        if (File.Exists(fileName))
//        {
//            string content = File.ReadAllText(fileName);
//            Console.WriteLine("Zawartość pliku:");
//            Console.WriteLine(content);
//        }
//        else
//        {
//            Console.WriteLine("Plik nie istnieje.");
//        }
//    }
//}


//class Task3
//{
//    public static int CountFemalePesels(string fileName)
//    {
//        if (!File.Exists(fileName))
//        {
//            Console.WriteLine("Plik nie istnieje.");
//            return 0;
//        }

//        string[] pesels = File.ReadAllLines(fileName);
//        return pesels.Count(p => p.Length == 11 && int.Parse(p[9].ToString()) % 2 == 0);
//    }
//}


//class Task4
//{
//    public class PopulationData
//    {
//        public Dictionary<string, Dictionary<int, long>> Population { get; set; }
//    }

//    public static PopulationData LoadPopulationData(string filePath)
//    {
//        if (!File.Exists(filePath))
//        {
//            Console.WriteLine("Plik bazy danych nie istnieje.");
//            return null;
//        }
//        string jsonString = File.ReadAllText(filePath);
//        return JsonSerializer.Deserialize<PopulationData>(jsonString);
//    }

//    public static long GetPopulationDifference(PopulationData data, string country, int year1, int year2)
//    {
//        return data.Population[country][year2] - data.Population[country][year1];
//    }
//}


//interface IPersonRepository
//{
//    void SavePerson(Person person);
//    List<Person> LoadPeople();
//}

//class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//    public string Email { get; set; }
//}

//class FilePersonRepository : IPersonRepository
//{
//    private string filePath = "people.json";

//    public void SavePerson(Person person)
//    {
//        List<Person> people = LoadPeople();
//        people.Add(person);
//        string jsonString = JsonSerializer.Serialize(people, new JsonSerializerOptions { WriteIndented = true });
//        File.WriteAllText(filePath, jsonString);
//    }

//    public List<Person> LoadPeople()
//    {
//        if (!File.Exists(filePath)) return new List<Person>();
//        string jsonString = File.ReadAllText(filePath);
//        return JsonSerializer.Deserialize<List<Person>>(jsonString) ?? new List<Person>();
//    }
//}

//class Program
//{
//    static void Main()
//    {
     
//        Task1.SaveAlbumNumber("album.txt", "123456");

        
//        Task2.ReadFileContent("album.txt");

       
//        Console.WriteLine("Liczba żeńskich PESEL-i: " + Task3.CountFemalePesels("pesels.txt"));

        
//        PopulationData data = Task4.LoadPopulationData("db.json");
//        if (data != null)
//        {
//            Console.WriteLine("Różnica populacji Indii (1970-2000): " + Task4.GetPopulationDifference(data, "India", 1970, 2000));
//        }

     
//        FilePersonRepository repo = new FilePersonRepository();
//        repo.SavePerson(new Person { Name = "Alicja", Age = 28, Email = "alicja@example.com" });
//        var people = repo.LoadPeople();
//        Console.WriteLine("Załadowane osoby:");
//        foreach (var person in people)
//        {
//            Console.WriteLine($"{person.Name}, {person.Age}, {person.Email}");
//        }
//    }
//}