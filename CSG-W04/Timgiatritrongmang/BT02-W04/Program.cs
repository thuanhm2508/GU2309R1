﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BT02_W04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C1();
            C2();
        }
        private static void C1()
        {
            string[] students = { "Christian", "Michael", "Camila", "Sienna", "Tanya", "Connor", "Zachariah", "Mallory", "Zoe", "Emily" };

            Console.WriteLine("Enter a name’s student:");
            string input_name = Console.ReadLine();

            bool isExist = false;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Equals(input_name))
                {
                    Console.WriteLine("Position of the students in the list " + input_name + " is: " + (i + 1));
                    isExist = true;
                    break;
                }
            }
            if (!isExist)
            {
                Console.WriteLine("Not found " + input_name + " in the list.");
            }

        }
        private static void C2()
        {
            ArrayList student = new ArrayList()
            {"Christian", "Michael", "Camila", "Sienna", "Tanya", "Connor", "Zachariah", "Mallory", "Zoe", "Emily"};
            Console.WriteLine("Enter a name’s student:");
            string input_name = Console.ReadLine();
            Console.WriteLine("Position of the students in the list " );

        }
    }
}