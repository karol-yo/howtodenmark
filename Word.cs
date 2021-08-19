using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace howtodenmark
{
    public class Word
    {
        private string NameInEnglish { get; set; }
        private string SingularUndefined { get; set; }
        private string SingularDefined { get; set; }
        private string PluralUndefined { get; set; }
        private string PluralDefined { get; set; }
        private int ID { get; set; }
        public int AmountAnsweredCorrectly { get; set; }
        public int AmountAnsweredIncorrectly { get; set; }
        private string Tag { get; set; }

        public static void AddWord()
        {
            Console.WriteLine("type the word in english");
            string WordInEnglish = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("type the singular undefined form in danish");
            string SingularUndefined = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("type the singular defined form in danish");
            string SingularDefined = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("type the plural undefined form in danish");
            string PluralUndefined = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("type the plural defined form in danish");
            string PluralDefined = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("type the tag for your word (or help for the list of all available tags)");
            string Tag = Console.ReadLine();
            //musi sprawdzac czy taki tag istnieje w liscie tagow i wgl, poki co przerwa

            Word word = new()
            {

            };

        }
    }


}
