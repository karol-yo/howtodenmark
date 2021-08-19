using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace howtodenmark
{
    class Tag
    {
        static string _path = Directory.GetCurrentDirectory();
        public string Name { get; set; }

        public static void AddTag()
        {
            Console.WriteLine("type the name of the tag you want to add");
            string name = Console.ReadLine();
            name.ToLower();
            Console.Clear();

            Tag tag = new()
            {
                Name = name
            };

            string TagListSerialized = File.ReadAllText(_path);
            var TagListDeserialized = JsonConvert.DeserializeObject<List<Tag>>(TagListSerialized);



            TagListDeserialized.Add(tag);
            TagListSerialized = JsonConvert.SerializeObject(TagListDeserialized);

            File.WriteAllText(_path + @"TagList", TagListSerialized);

            Console.Clear();
            Console.WriteLine($"tag {tag.Name} has been added successfully");
        }

        public static void ListOfTags()
        {
            var ListOfTagsDeserialized = JsonConvert.DeserializeObject<List<Tag>>(_path + @"TagList.json");

            foreach (var tag in ListOfTagsDeserialized)
            {
                Console.WriteLine(tag.Name);
            }
        }
    }
}
