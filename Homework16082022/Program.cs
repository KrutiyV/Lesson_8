using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace HomeWork
{
    class RegexHomeWork
    {
        static void Main(string[] args)
        {
            var PhoneBook = new string[]
            { 
                "Clark Kent 38012345678",
                "Matt Rigs 38023758474",
                "Hanna Montana 38047627597",
                "Anthony Diamond 38075327594",
                "Riley Jackson 38047222587",
                "Katty Moor 38047627853"
            };

            int str1;
            List<string> str2 = new List<string>();
            Console.WriteLine("Enter name or phone number to search:");

            string Matches = Console.ReadLine();
            Regex regex = new Regex(Matches);

            foreach (var contact in PhoneBook)
            {
                MatchCollection MatchesCollection = regex.Matches(contact);
                str1 = MatchesCollection.Count;
                if (MatchesCollection.Count > 0)
                {
                    str2.Add(contact);
                }
            }
            if (str2.Count > 0)
            {
                Console.WriteLine("Search Result:");
                foreach (var person in str2)
                {
                    Console.WriteLine(person);
                }
            }
            else
            {
                Console.WriteLine("Sorry, nothing is matches :(");
            }
        }
    }
}
