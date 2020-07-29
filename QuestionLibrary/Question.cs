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
        public string hat { get; set; } 

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
                //start reading file
                // The files used in this example are createdin the topic 
                // How to: write to a text File. You can change the path and 
                //file name to substitute text file of you own.

                // Eaxmple #1 
                /*// Read the file as one string.
                string text = System.IO.File.ReadAllText(@"C:\Users\Dakota\Source\Repos\QuestionGameSolution\GameQuestions.txt");

                // Display the file contents to the console. Variable text is a string.
                System.Console.WriteLine("Contents of WriteText.txt = {0}" , text);
                */
                // Example #2 
                // Read each line of the file into a string array. Each element
                //of the array is one line of the file.
                string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Dakota\Source\Repos\QuestionGameSolution\GameQuestions.txt");

                // Display the File contents by using a foreach loop.
                System.Console.WriteLine("Contents of WriteLines2.txt = ");
                foreach (string line in lines)
                {
                    // Use a tab to indent each line of the file.
                    Console.WriteLine("\t" + line);

                }
                //Keep the Console window open in debug mode.
                Console.WriteLine("Press any key to exit.");
                System.Console.ReadKey();
                 
                /*
                // Read entire text file content in one string 
                string text = File.ReadAllText(textFile);
                console.WriteLine(text);

                //Read a text file line by line.
                string[] lines = File.ReadAllLines(textfile);

                foreach (string line in lines)
                Console.WriteLine(line);

                //Read file using StreamReader. Reads file lineby line
                using(StraemReader file = new StreamReader(textFile)){
                int counter = 0;
                string ln;

                while((ln = file.ReadLine()) !=null){
                Console.WriteLine(ln);
                counter++;
                }
                */
                
            }
            catch (Exception ex)
            {

                throw;
            }

            return questions;
        }
    }
}
