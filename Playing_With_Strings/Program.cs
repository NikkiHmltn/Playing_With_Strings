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
            Console.Write(result);
        }
    }
}
