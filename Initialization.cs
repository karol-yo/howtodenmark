using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace howtodenmark
{
    class Initialization
    {
        public static string FileCheck()
        {
            string path = Directory.GetCurrentDirectory();

            if (!File.Exists(path + @"TagList.json"))
            {
                File.Create(path + @"TagList.json");
            }

            if (!File.Exists(path + @"WordList.json"))
            {
                File.Create(path + @"WordList.json");
            }

            if (!File.Exists(path + @"User.json"))
            {
                Console.WriteLine("i see u want to learn how to denmark, tell me how they call you");
                string UserName = Console.ReadLine();
                Console.Clear();

                User user = new()
                {
                    Name = UserName,
                };

                string UserSerialized = JsonConvert.SerializeObject(user);
                File.WriteAllText(path + @"User.json", UserSerialized);

                return "executing the code for the first time";
            }
            else
            {
                return "reexecuting the code";
            }
        }
    }
}
