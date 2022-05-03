﻿using System;

namespace StoringText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Literal Strings
            char letter = 'A'; //assigning literal characters
            char digit = '1';
            char symbol = '$';

            //char userChoice = GetKeystroke(); // assigning from a function

            string firstName = "Bob"; // assigning literal string
            string lastName = "Smith";
            string phoneNumber = "(215) 555-4256";

            // assigning a string returned from a function call
            //string address = GetAddressFromDatabase(id: 563);
            #endregion

            #region Verbatim Strings
            string fullNameWithTabSeparator = "Bob\tSmith";
            string filePath = @"C:\televisions\sony\bravia.txt";
            #endregion
        }
    }
}