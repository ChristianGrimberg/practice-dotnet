using System; // a semicolon indicates the end of a statement

// #error version
// This is a line comment
/*
This is a multi-line
comment.
*/

namespace Basics
{ // an open brace indicates the start of a block
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); // a statement
            Console.WriteLine("");
            Console.WriteLine("Temperature on {0:D} is {1} Celsius", DateTime.Now, 15);
        }
    }
} // a close brace indicates the end of a block
