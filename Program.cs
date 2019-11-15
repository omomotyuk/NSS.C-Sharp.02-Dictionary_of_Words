using System;
using System.Collections.Generic;

namespace _03.Dictionary_of_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");


            /*
                Create a dictionary with key value pairs to represent words (key) and its definition (value)
            */
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // Add several more words and their definitions
            wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
            wordsAndDefinitions.Add("Feeling", "A belief, especially a vague or irrational one");
            wordsAndDefinitions.Add("Student", "Denoting someone who is studying in order to enter a particular profession");
            wordsAndDefinitions.Add("Learning", "The acquisition of knowledge or skills through experience, study, or by being taught");
            wordsAndDefinitions.Add("C#", "An object-oriented programming language from Microsoft");
            wordsAndDefinitions.Add("Belief", "An acceptance that a statement is true or that something exists");
            wordsAndDefinitions.Add("Especially", "Used to single out one person, thing, or situation over all others");
            wordsAndDefinitions.Add("Vague", "Of uncertain, indefinite, or unclear character or meaning");
            wordsAndDefinitions.Add("Irrational", "Not logical or reasonable");
            wordsAndDefinitions.Add("Denote", "Be a sign of, indicate");

            /*
                Use square brackets to get the definition of two of the words and then output them to the console
            */

            string word = "C#";
            string definition = wordsAndDefinitions[word];
            Console.WriteLine($"Definition of \"{word}\" is \"{definition}\"");

            word = "Vague";
            definition = wordsAndDefinitions[word];
            Console.WriteLine($"Definition of \"{word}\" is \"{definition}\"");


            /*
                Below, loop over the wordsAndDefinitions dictionary to get the following output:
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
            */

            Console.Write("\n");

           foreach (KeyValuePair<string, string> item in wordsAndDefinitions)
            {
                Console.WriteLine($"Definition of \"{item.Key}\" is \"{item.Value}\"");
            }
        }
    }
}
