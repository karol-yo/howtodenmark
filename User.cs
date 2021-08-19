using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace howtodenmark
{
    class User
    {
        public int CorrectAnswers { get; set; }
        public int IncorrectAnswers { get; set; }
        public int Points { get; set; }
        public string Name { get; set; }
        public static void FirstGreetings()
        {
            string path = Directory.GetCurrentDirectory();
            string UserSerialized = File.ReadAllText(path + @"User.Json");
            User UserDeserialized = JsonConvert.DeserializeObject<User>(UserSerialized);

            Console.WriteLine($"Welcome, {UserDeserialized.Name}");
        }
        public static void Greetings()
        {
            string path = Directory.GetCurrentDirectory();
            string UserSerialized = File.ReadAllText(path + @"User.Json");
            User UserDeserialized = JsonConvert.DeserializeObject<User>(UserSerialized);

            Console.WriteLine($"Welcome back, {UserDeserialized.Name}");
        }
    }
    
}
