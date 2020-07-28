using QuestionLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var questions = Question.LoadQuestions();

            foreach (var question  in questions)
            {
                Console.WriteLine(question.QuestionText);

                // Need to display the question answer choices.

                Console.Write("Your answer is? ");
                Console.ReadLine();
            }
        }
    }
}
