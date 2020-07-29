using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningStuff
{
    public class VariableReview
    {
        public void VariableInt()
        {
            var usingVarDefaultsToInt = 100;
            int thisIsAnotherInt = 200;
            long isAVeryLargeNumber = 99999999999999;

            // These can all be added together.
            var total = usingVarDefaultsToInt + thisIsAnotherInt + isAVeryLargeNumber;

            Console.WriteLine($"Sum: {total}");
        }

        public void VariableString()
        {
            string testString = "This is a string";
            var anotherTestString = "String defined as var.";
            var stringAsNumber = "12345";

            Console.WriteLine("The string values:");
            Console.WriteLine($"testString: {testString}");
            Console.WriteLine($"anotherTestString: {anotherTestString}");
            Console.WriteLine($"stringAsNumber: {stringAsNumber}");
        }
    }
}
