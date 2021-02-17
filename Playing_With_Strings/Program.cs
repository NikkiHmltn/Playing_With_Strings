using System;

namespace Playing_With_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringOne = "16";
            string stringTwo = "15";
            int num1 = Int32.Parse(stringOne);
            int num2 = Int32.Parse(stringTwo);
            int result = num1 + num2;
            Console.WriteLine(result);

            //SubString(int32) is used to get the substring from the string, starting at the specified index
            //ToLower() used to convert the string to lowercase
            //ToUpper() used to convert string to uppercase
            //Trim() used to trim all leading and trailing white space from the string
            //IndexOf(string) used to get the index of the string or char inside the string
            //InNullorWhiteSpace returns true if the string is null or blank, else returns false

            string firstName = "Nikki";
            string lastName = "Hamilton";
            string fullName = string.Concat(" ", firstName, lastName, " ");
            Console.WriteLine(firstName.Substring(2)); //output: kki
            Console.WriteLine(firstName.ToLower()); //output: nikki
            Console.WriteLine(firstName.ToUpper()); //output: NIKKI
            Console.WriteLine(fullName.Trim()); //output: NikkiHamilton
            Console.WriteLine(firstName.IndexOf('i')); //output: 1 (only grabs first instance of 'i')
            Console.WriteLine(String.IsNullOrWhiteSpace(firstName)); //output: false

            //String.Format methos is used to insert the object or variable value inside any string
            //with String.Format we replace the value in the specified format
            //Syntax: String.Format("any string {index}", object);

            Console.WriteLine(String.Format("My name is {0}.", firstName)); //output: My name is Nikki.

            //String Challenge 1

            //declare a string variable and assign no value
            string catName;

            //print console "Please enter your name and and press enter"
            Console.WriteLine("Please enter your cat's name and press enter");
            //assign entered string to string variable
            string userInput = Console.ReadLine();
            catName = userInput;
            //first line, string in uppercase
            Console.WriteLine(String.Format("Upper case: {0}",catName.ToUpper()));
            //second line, lowercase
            Console.WriteLine(String.Format("Lower case: {0}",catName.ToLower()));
            //third line, no white space
            Console.WriteLine(String.Format("No whitespace: {0}",catName.Trim()));
            //last line, substring of the entered string on the console
            Console.WriteLine(String.Format("Substring: {0}",catName.Substring(1)));


            //String Challenge 2

            //ask the user to input a string
            Console.WriteLine("Please enter a string:");
            string stringInput = Console.ReadLine();

            //ask the user for the character to search in the string they entered
            Console.WriteLine("Enter the character to search:");
            string stringSearch = Console.ReadLine();

            //write the index of the first occurrence
             Console.WriteLine(String.Format("Index: {0}",stringInput.IndexOf(stringSearch)));

            // ask to enter first name...
            Console.WriteLine("Enter first name:");
            string first = Console.ReadLine();

            // ...then ask for last name
            Console.WriteLine("Enter last name:");
            string last = Console.ReadLine();

            //then print the full name on a single line, store in variable before display
            string fullestName = first + " " + last;
            Console.WriteLine(String.Format("Your full name is {0}", fullestName));
        }
    }
}
