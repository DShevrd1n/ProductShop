using System;
using System.Linq;
using System.Text.Json;
using System.IO;
using ProductShopOOP.Models;
using System.Collections.Generic;

namespace ProductShopOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            string FileName = "clients.json";
            var clients = createClient();
            
            Console.WriteLine(clients[0].Role);
            JsonSerialization(FileName, clients);
            Console.WriteLine(File.ReadAllText(FileName));
            Client[] clients1 = (Client[])JsonDeserialization<Client[]>(FileName);
            Console.WriteLine(clients1[0].Age);
            List<Client> ClientsList = new List<Client>(clients1);
            // LinqSort
            Console.WriteLine(new string('_', 50));
            var sortedClients = from u in ClientsList
                              orderby u.Age,u.Name
                              select u;
            foreach (Client u in sortedClients)
                Console.WriteLine(u.Age);
                
            //LinqSelecting
            Console.WriteLine(new string('_',50));
            var selectedClients = from u in ClientsList
                                  where u.Age >= 18
                                  select u;
            foreach (Client u in selectedClients)
                Console.WriteLine(u.Name);
            


        }
        static Client[] createClient()
        {
            Client[] clients = new Client[10];
            clients[0] = new Client {Id=0, Age=18,Name="Tom",Email="gsf@gmail.com",Login="tom_2003",Password="1234923" };
            clients[1] = new Client { Id = 1, Age = 21, Name = "Elis", Email = "ophjk.wq@gmail.com", Login = "elis_2000", Password = "1234923" };
            clients[2] = new Client { Id = 2, Age = 15, Name = "Edward", Email = "hnkamsqmg@gmail.com", Login = "ed_1999", Password = "1fsdhd54" };
            clients[3] = new Client { Id = 3, Age = 15, Name = "Alex", Email = "hgdfhmqg145a@gmail.com", Login = "alex_2006", Password = "dkgjh4/sdg" };
            clients[4] = new Client { Id = 4, Age = 16, Name = "Sonya", Email = "adglw445@gmail.com", Login = "sonua_2005", Password = "a24dsgaf" };
            clients[5] = new Client { Id = 5, Age = 16, Name = "Aleksandr", Email = "adglw445@gmail.com", Login = "sonua_2005", Password = "a24dsgaf" };
            clients[6] = new Client { Id = 6, Age = 21, Name = "Tanya", Email = "adglw445@gmail.com", Login = "sonua_2005", Password = "a24dsgaf" };
            clients[7] = new Client { Id = 7, Age = 18, Name = "Zhenya", Email = "adglw445@gmail.com", Login = "sonua_2005", Password = "a24dsgaf" };
            clients[8] = new Client { Id = 8, Age = 22, Name = "Lera", Email = "adglw445@gmail.com", Login = "sonua_2005", Password = "a24dsgaf" };
            clients[9] = new Client { Id = 9, Age = 15, Name = "Sonya", Email = "adglw445@gmail.com", Login = "sonua_2005", Password = "a24dsgaf" };
            return clients;
        }
        static void JsonSerialization(string path, object obj)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string jsonString = JsonSerializer.Serialize(obj, options);
            File.WriteAllText(path, jsonString);
        }
        static object JsonDeserialization<T>(string path)
        {
            string jsonString = File.ReadAllText(path);
            T restoredFile = JsonSerializer.Deserialize<T>(jsonString);
            return restoredFile;
        }
        

    }
}
