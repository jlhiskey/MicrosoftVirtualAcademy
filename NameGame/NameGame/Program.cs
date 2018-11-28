﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Name Game");

            Console.WriteLine("What's your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What's your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("In what city were you born?");
            string city = Console.ReadLine();

            DisplayResult(ReverseString(firstName), 
                ReverseString(lastName), 
                ReverseString(city));

            Console.ReadLine();
        }

        private static string ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return String.Concat(messageArray);
        }
        private static void DisplayResult(
            string reversedFirstName, 
            string reversedLastName, 
            string reversedCity)
        {
            Console.Write("Results: ");
            Console.Write(String.Format("{0} {1} {2}",
                           reversedFirstName,
                           reversedLastName,
                           reversedCity));
        }
    }
}
