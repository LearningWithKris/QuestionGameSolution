using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionLibrary
{
    public class Question
    {
        public string QuestionText { get; set; }
        public List<string> AnswerOptions { get; set; }

        public static List<Question> LoadQuestions()
        {
            var questions = new List<Question>();

            try
            {
                // Build a question and add it to the list.
                questions.Add(new Question()
                {
                    QuestionText = "What is the capital of Indiana?",
                    AnswerOptions = new List<string>() { "Seymour", "Columbus", "New Washington", "Fort Wayne", "Indianapolis" }
                });
            }
            catch (Exception ex)
            {

                throw;
            }

            return questions;
        }
    }
}
