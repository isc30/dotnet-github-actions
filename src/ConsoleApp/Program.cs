﻿using System;
using ClassLib;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string json = Json.Serialize(new
            {
                Name = "Ivan",
                Surname = "Sanz",
            });

            Console.WriteLine(json);
        }
    }
}
