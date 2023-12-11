using System;

namespace DemoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Cena";
            var lastName = "Jon";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("my name is{0} {1}", firstName, lastName);

            var names = new string[3] { "Jon", "Cena", "Mary" };
            var formattedNames = string.Join(",", names);

            Console.WriteLine(formattedNames);

            //YOU CAN DO LINE OF CODE BELLOW ANOTHER BETTER AND MORE CLEAN WAY OF DOING CODE ON EX 2

            //var text = "Hi Jon\nLook into the following paths\nc:\\folder1\\folder2\\nc:\\folder3\\folder4";
            //Console.WriteLine(text);

            // EX 2 THIS IS A BETTER WAY MAKE SURE TO AT @ FROM THE BEGENNING 

            var text = @"Jon Look into the following paths  
                c:\folder1/folder2  
                c:\folder3\folder4";
            Console.WriteLine(text);
            //String lastName = "Jon";
            //string myName = "mosh";
        }
    }
}
