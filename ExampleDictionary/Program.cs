using System;
using System.Collections.Generic;

namespace ExampleDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "The Originals");
            myDictionary.Add(2, "Sense 8");
            myDictionary.Add(3, "Supernatural");
            myDictionary.Add(4, "Teen Wolf");
            myDictionary.Add(5, "How I Mether Your Mother");
            myDictionary.Add(6, "Dark");

            Console.WriteLine("Dizi ID: " + myDictionary.Keys[0] + " Dizi Adı: " + myDictionary.Values[0]);
            Console.WriteLine("Dizi ID: " + myDictionary.Keys[1] + " Dizi Adı: " + myDictionary.Values[1]);
            Console.WriteLine("Dizi ID: " + myDictionary.Keys[2] + " Dizi Adı: " + myDictionary.Values[2]);
            Console.WriteLine("Dizi ID: " + myDictionary.Keys[3] + " Dizi Adı: " + myDictionary.Values[3]);
            Console.WriteLine("Dizi ID: " + myDictionary.Keys[4] + " Dizi Adı: " + myDictionary.Values[4]);
            Console.WriteLine("Dizi ID: " + myDictionary.Keys[5] + " Dizi Adı: " + myDictionary.Values[5]);
        }
    }
}
