//using System;
//using System.Collections.Generic;
//using Microsoft.Data.SqlClient;

//namespace CustomerManagement
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            ClientManager clientManager = new ClientManager();
//            while (true)
//            {
//                Console.WriteLine("\n1. Dodaj klienta");
//                Console.WriteLine("2. Wyświetl klientów");
//                Console.WriteLine("3. Zaktualizuj klienta");
//                Console.WriteLine("4. Usuń klienta");
//                Console.WriteLine("5. Wyszukaj klienta");
//                Console.WriteLine("6. Wyjście");
//                Console.Write("Wybierz opcję: ");

//                int choice;
//                if (!int.TryParse(Console.ReadLine(), out choice)) continue;

//                switch (choice)
//                {
//                    case 1:
//                        clientManager.AddClient();
//                        break;
//                    case 2:
//                        clientManager.DisplayClients();
//                        break;
//                    case 3:
//                        clientManager.UpdateClient();
//                        break;
//                    case 4:
//                        clientManager.DeleteClient();
//                        break;
//                    case 5:
//                        clientManager.SearchClient();
//                        break;
//                    case 6:
//                        return;
//                    default:
//                        Console.WriteLine("Nieprawidłowa opcja!");
//                        break;
//                }
//            }
//        }
//    }

//    class DatabaseManager
//    {
//        private readonly string connectionString = "Server=localhost;Database=CustomerDB;Trusted_Connection=True;";

//        public void ExecuteQuery(string query, Action<SqlCommand> parameterSetter = null)
//        {
//            using (SqlConnection conn = new SqlConnection(connectionString))
//            {
//                conn.Open();
//                using (SqlCommand cmd = new SqlCommand(query, conn))
//                {
//                    parameterSetter?.Invoke(cmd);
//                    cmd.ExecuteNonQuery();
//                }
//            }
//        }

//        public List<Client> ReadClients(string query, Action<SqlCommand> parameterSetter = null)
//        {
//            List<Client> clients = new List<Client>();
//            using (SqlConnection conn = new SqlConnection(connectionString))
//            {
//                conn.Open();
//                using (SqlCommand cmd = new SqlCommand(query, conn))
//                {
//                    parameterSetter?.Invoke(cmd);
//                    using (SqlDataReader reader = cmd.ExecuteReader())
//                    {
//                        while (reader.Read())
//                        {
//                            clients.Add(new Client
//                            {
//                                Id = reader.GetInt32(0),
//                                FirstName = reader.GetString(1),
//                                LastName = reader.GetString(2),
//                                Email = reader.GetString(3),
//                                Phone = reader.GetString(4),
//                                RegistrationDate = reader.GetDateTime(5)
//                            });
//                        }
//                    }
//                }
//            }
//            return clients;
//        }
//    }

//    class ClientManager
//    {
//        private DatabaseManager dbManager = new DatabaseManager();

//        public void AddClient()
//        {
//            Console.Write("Imię: ");
//            string firstName = Console.ReadLine();
//            Console.Write("Nazwisko: ");
//            string lastName = Console.ReadLine();
//            Console.Write("Email: ");
//            string email = Console.ReadLine();
//            Console.Write("Telefon: ");
//            string phone = Console.ReadLine();
//            string query = "INSERT INTO Klienci (Imie, Nazwisko, Email, Telefon, DataRejestracji) VALUES (@Imie, @Nazwisko, @Email, @Telefon, GETDATE())";
//            dbManager.ExecuteQuery(query, cmd => {
//                cmd.Parameters.AddWithValue("@Imie", firstName);
//                cmd.Parameters.AddWithValue("@Nazwisko", lastName);
//                cmd.Parameters.AddWithValue("@Email", email);
//                cmd.Parameters.AddWithValue("@Telefon", phone);
//            });
//            Console.WriteLine("Klient dodany!");
//        }

//        public void DisplayClients()
//        {
//            List<Client> clients = dbManager.ReadClients("SELECT * FROM Klienci");
//            foreach (var client in clients)
//            {
//                Console.WriteLine($"{client.Id}: {client.FirstName} {client.LastName} - {client.Email} - {client.Phone} - {client.RegistrationDate}");
//            }
//        }

//        public void UpdateClient()
//        {
//            Console.Write("Podaj ID klienta do aktualizacji: ");
//            int id = int.Parse(Console.ReadLine());
//            Console.Write("Nowy Email: ");
//            string email = Console.ReadLine();
//            Console.Write("Nowy Telefon: ");
//            string phone = Console.ReadLine();
//            string query = "UPDATE Klienci SET Email = @Email, Telefon = @Telefon WHERE Id = @Id";
//            dbManager.ExecuteQuery(query, cmd => {
//                cmd.Parameters.AddWithValue("@Email", email);
//                cmd.Parameters.AddWithValue("@Telefon", phone);
//                cmd.Parameters.AddWithValue("@Id", id);
//            });
//            Console.WriteLine("Dane zaktualizowane!");
//        }

//        public void DeleteClient()
//        {
//            Console.Write("Podaj ID klienta do usunięcia: ");
//            int id = int.Parse(Console.ReadLine());
//            string query = "DELETE FROM Klienci WHERE Id = @Id";
//            dbManager.ExecuteQuery(query, cmd => cmd.Parameters.AddWithValue("@Id", id));
//            Console.WriteLine("Klient usunięty!");
//        }

//        public void SearchClient()
//        {
//            Console.Write("Podaj nazwisko do wyszukania: ");
//            string lastName = Console.ReadLine();
//            string query = "SELECT * FROM Klienci WHERE Nazwisko LIKE @Nazwisko";
//            List<Client> clients = dbManager.ReadClients(query, cmd => cmd.Parameters.AddWithValue("@Nazwisko", "%" + lastName + "%"));
//            foreach (var client in clients)
//            {
//                Console.WriteLine($"{client.Id}: {client.FirstName} {client.LastName} - {client.Email} - {client.Phone}");
//            }
//        }
//    }

//    class Client
//    {
//        public int Id { get; set; }
//        public string FirstName { get; set; }
//        public string LastName { get; set; }
//        public string Email { get; set; }
//        public string Phone { get; set; }
//        public DateTime RegistrationDate { get; set; }
//    }
//}
