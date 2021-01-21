using System;
using System.Collections;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> idName = new MyDictionary<int, string>();
            idName.Add(1, "Nisa");
            idName.Add(2, "Begüm");
            idName.Add(3, "Gizem");
            idName.Add(4, "İrem");
            
            Console.WriteLine(idName.Count);

            Console.ReadLine();
        }
    }
}
