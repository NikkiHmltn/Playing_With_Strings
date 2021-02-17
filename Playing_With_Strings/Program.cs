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
            Console.WriteLine(catName.ToUpper());
            //second line, lowercase
            Console.WriteLine(catName.ToLower());
            //third line, no white space
            Console.WriteLine(String.IsNullOrWhiteSpace(catName));
            //last line, substring of the entered string on the console
            Console.WriteLine(catName.Substring(1));

        }
    }
}
