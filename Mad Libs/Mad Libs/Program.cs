﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mad_Libs
{
    class Program
    {
        static void Main(string[] args)
        {
            String color;
            String wordEst;
            String bodyPartPlural;
            String noun;
            String anAnimal;
            String pluralNoun;
            int a;
            int b;
            int c;

            Console.WriteLine("What is your favorit color >>> ");
            color = Console.ReadLine();

            Console.WriteLine("Enter a word ending in EST >>> ");
            wordEst = Console.ReadLine();

            Console.WriteLine("Enter a body part plural >>> ");
            bodyPartPlural = Console.ReadLine();

            Console.WriteLine("Enter an animal >>> ");
            anAnimal = Console.ReadLine();

            Console.WriteLine("Enter a noun >>> ");
            noun = Console.ReadLine();

            Console.WriteLine("Enter a plural noun >>> ");
            pluralNoun = Console.ReadLine();

            Console.WriteLine("Enter a number >>> ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number but smaller than the first >>> ");
            b = Convert.ToInt32(Console.ReadLine());
            c = a - b;

            Console.WriteLine("The {0} Dragon is the " + "{1} Dragon of all time. It has {2} {3}, " +
                "and a {4} shaped like a {5}. It loves to " + " eat {6} although it will feast" +
                " on nearly anything.", color, wordEst, c, bodyPartPlural, anAnimal, noun, pluralNoun);
        }
    }
}
