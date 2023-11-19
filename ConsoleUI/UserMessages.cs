﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class UserMessages
    {
        public static void ApplicationStartMessage()
        {
            Console.WriteLine("Welcome to the Static Class Demo Application");

            int hourOfDay = DateTime.Now.Hour;

            if (hourOfDay < 12)
            {
                Console.WriteLine($"Good Morning { firstName }!");
            }
            else if (hourOfDay < 19)
            {
                Console.WriteLine($"Good Afternoon { firstName }!");
            }
            else
            {
                Console.WriteLine($"Good Evening { firstName }!");
            }

            
        }

       public static void PrintResultMessage(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine();
            Console.WriteLine("Thank you for using our application to calculate for you.");
        }
    }
}
