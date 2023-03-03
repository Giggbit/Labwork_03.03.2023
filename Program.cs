using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Labwork_03._03._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            string str = Console.ReadLine();

            #region ex1
            /*string pattern = @"^([0-2][0-9]{0,2}\.){3}([0-9]{1,3})";
            Regex regex = new Regex(pattern);

            if(regex.IsMatch(str)) {
                Console.WriteLine("It's correct IP adress");
            }
            else {
                Console.WriteLine("It's uncorrect IP adress");
            }*/
            #endregion

            #region ex2
            /*string[] mas = { "привет", "меня", "зовут" };

            string pattern = @"[а]|[о]|[у]|[и]|[ю]|[е]|[я]|[ы]|[э]";
            Regex regex = new Regex(pattern);

            foreach(string s in mas) { 
                if (regex.IsMatch(s)) {
                    Console.WriteLine("Совпадение: {0}", s);
                }
            }*/
            #endregion

            #region ex3
            /*string pattern = @"^(https:\/\/)\w+\.\w+$";
            Regex regex = new Regex(pattern);

            if(regex.IsMatch(str)) {
                Console.WriteLine("It's correct url");
            }
            else { 
                Console.WriteLine("It's uncorrect url");
            }*/
            #endregion

            #region ex4
            /*string pattern = @"^\w+$";
            Regex regex = new Regex(pattern);

            if(regex.IsMatch(str)) { 
                Console.WriteLine("It's correct string!");
            }
            else {
                Console.WriteLine("It's uncorrect string!");
            }*/
            #endregion

            #region ex5
            /*string pattern = @"^([0-1][0-9]|[2][0-3])(:)([0-5][0-9])(:)([0-5][0-9])?$";
            Regex regex = new Regex(pattern);

            if(regex.IsMatch(str)) {
                Console.WriteLine("It's correct time");
            }
            else {
                Console.WriteLine("It's uncorrect time");
            }*/
            #endregion

            #region ex6
            /*string pattern = @"[0-9]{5}";
            Regex regex = new Regex(pattern);

            if(regex.IsMatch(str)) {
                Console.WriteLine("It's correct index");
            }
            else {
                Console.WriteLine("It's uncorrect index");
            }*/
            #endregion

            /* Console.WriteLine("Enter email:");
             string email = Console.ReadLine();

             string pattern = @"^\D\w+(@gmail\.com)$";
             Regex regex = new Regex(pattern);

             if (regex.IsMatch(email)) { 
                 Console.WriteLine("It's correct");
             }
             else {
                 Console.WriteLine("It's incorrect");
             }*/
        }
    }
}
