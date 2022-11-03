using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace homeworkV9
{
    public class Cypher
    {
        public string word { get; set; }
        public int key { get; set; }

        public void cip()
        {
            Cypher cyp = new();
            StreamReader streamreader = new StreamReader(@"C:\Users\lasha\Desktop\c-homeworks\homeworkV9\homeworkV9\Json\Cipher.json");
            string jsonstring = streamreader.ReadToEnd();
            Cypher cypher = JsonConvert.DeserializeObject<Cypher>(jsonstring);
            cyp.word = cypher.word;
            cyp.key = cypher.key;

            string final = "";
            for (int i = cyp.key; i < cyp.word.Length; i++)
            {
                final += cyp.word[i];
            }
            for (int j = 0; j < cyp.key; j++)
            {
                final += cyp.word[j];
            }
            Console.WriteLine(final);
        }
        public void Getnum()
        {
            Cypher cyp = new();
            StreamReader streamreader = new StreamReader(@"C:\Users\lasha\Desktop\c-homeworks\homeworkV9\homeworkV9\jjs\Cipher.json");
            string jsonstring = streamreader.ReadToEnd();
            Cypher cypher = JsonConvert.DeserializeObject<Cypher>(jsonstring);
            JObject rss = JObject.Parse(jsonstring);
            Console.Write("Enter the (Cypher) Number : ");
            string num = Console.ReadLine();
            rss["key"] = ((string)rss["key"]).Replace((string)rss["key"], num);
            File.WriteAllText(@"C:\Users\lasha\Desktop\c-homeworks\homeworkV9\homeworkV9\Json\Cipher.json", rss.ToString());
            try
            {
                cyp.cip();
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Number is greater than 26.");
                Console.ResetColor();
            }
        }
    }
}
