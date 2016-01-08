using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;


namespace NewPhoneBook
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> myPhoneBook = new Dictionary<string, string>();
            Console.WriteLine("Enter Name and Phone Number:");
            string s = Console.ReadLine();

            while (s!= "Exit")
            {
                string[] keyVal = s.Split(new char[] { ',' });
                myPhoneBook.Add(keyVal[0], keyVal[1]);
                s = Console.ReadLine();
            }
            Program.SavePhoneBook(myPhoneBook);
            Process.Start(@"notepad.exe", @"PhoneBook.txt");
        }
        private static void SavePhoneBook(Dictionary<string,string> entries)
        {
            using (StreamWriter writer = File.CreateText(@"PhoneBook.txt"))
            {
                foreach(var pair in entries)
                {
                    writer.WriteLine(("Name:")+ pair.Key+ "," +("Phone Number:")+ pair.Value);
                    writer.Close();
                }
            }
        }
        private static void  ErasePhoneBook(Dictionary<string, string> entries)
        {
            Console.WriteLine("Enter name to errase:");
            string erraseName = Console.ReadLine();
            using (StreamReader writer = File.Open(@"PhoneBook.txt"))

            {
                foreach (var pair in entries)
                {
                    writer.;
                }
            }
        }



    }
}
