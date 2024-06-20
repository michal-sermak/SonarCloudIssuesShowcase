using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SonarCloudDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example of unused variable (Code Smell)
            int unusedVariable = 42;

            // Example of bug: Null reference exception
            string nullString = null;
            Console.WriteLine(nullString.Length);

            // Example of potential security issue: Hardcoded credentials
            string username = "admin";
            string password = "password123";

            // Example of deprecated method usage
            var obsoleteClass = new ObsoleteClass();
            obsoleteClass.ObsoleteMethod();

            // Example of inefficient loop (Code Smell)
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            foreach (var number in numbers)
            {
                if (numbers.Contains(number))
                {
                    Console.WriteLine(number);
                }
            }

            // Example of not handling exceptions (Code Smell)
            try
            {
                int.Parse("not an integer");
            }
            catch { }

            // Example of not closing a resource (Bug)
            var file = File.Open("file.txt", FileMode.Open);
            // No file.Close() here

            // Example of SQL injection vulnerability
            string userInput = "'; DROP TABLE Users; --";
            string sqlQuery = "SELECT * FROM Users WHERE Name = '" + userInput + "'";

            // Example of non-compliant naming convention
            int camel_case_variable = 0;

            // Example of magic numbers (Code Smell)
            int result = AddMagicNumbers(4, 7);
            Console.WriteLine(result);
        }

        // Example of method with poor documentation
        static int AddMagicNumbers(int a, int b)
        {
            return a + b;
        }
    }

    // Example of deprecated class (Code Smell)
    [Obsolete("This class is deprecated")]
    class ObsoleteClass
    {
        [Obsolete("This method is deprecated")]
        public void ObsoleteMethod()
        {
            Console.WriteLine("Obsolete method called");
        }
    }
}
