﻿// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp
{
    class Car
    {
        private string handle = "AMODEL";

        public void carRun()
        {
            Console.WriteLine("자동");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("System");
            Console.WriteLine("Hello, C#!");
        }
    }
}