using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] questions = {

                "What is the capital of India?",
                "Which language is used for .NET?",
                "What does CPU stand for?",
                "Which symbol is used for comments in C#?",
                "How many days are there in a week?"

            };
            string[,] options = {

              { "1. Mumbai", "2. Delhi", "3. Chennai", "4. Kolkata" },
              { "1. Java", "2. Python", "3. C#", "4. C" },
              { "1. Central Process Unit", "2. Control Processing Unit", "3. Central Processing Unit", "4. Computer Process Unit" },
              { "1. //", "2. ##", "3. <!-- -->", "4. **" },
              { "1. 5", "2. 6", "3. 7", "4. 8" }

            };
            int[] correctAnswers = { 2, 3, 3, 1, 3 };

            int score = 0;

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine("\nQ" + (i + 1) + ": " + questions[i]);

                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine(options[i, j]);

                }

                Console.Write("Your answer (1-4): ");
                int userAnswer = int.Parse(Console.ReadLine());

                if (userAnswer == correctAnswers[i])
                {
                    score++;
                }

            }
            Console.WriteLine("\n🎉 Quiz Finished!");
            Console.WriteLine("Your Score: " + score + "/" + questions.Length);


        }
    }
}
