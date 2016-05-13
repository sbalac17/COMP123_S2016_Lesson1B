using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Tom Tsiliopoulos
 * Date Created: May 13, 2016
 * Date Modified: May 13, 2016
 * Student ID: 30018557
 * 
 * Description: This program demonstrates GitHub and version control
 * best practices. We also explore Unit Testing
 * 
 * Version: 0.4 - extracted OutputStringToConsole from GetUserName method
 */


namespace COMP123_S2016_Lesson1B
{
    /**
     * This is the driver class for our program
     * 
     * @class Program
     */
    class Program
    {
        /**
         * Main Method for class Program
         * 
         * @param {string[]} args
         * @constructor Main
         */
        static void Main(string[] args)
        {
            GetUserName();
        }


        /**
         * This method reads the UserName from the Console
         * 
         * @method GetUserName
         * @return {string} UserName
         */
        public static string GetUserName()
        {
            // Initialize Variables
            string UserName = "";

            OutputStringToConsole("Enter UserName: ", false);
            UserName = Console.ReadLine();

            Console.WriteLine("\n=========================\n");
            Console.WriteLine("You Entered: " + UserName + "\n");

            return UserName;
        }

        /**
         * This method writes a string to the console. Parameters allow the user to
         * choose to add a newLine character
         * 
         * @method OutputStringToConsole
         * @param {string} outputString
         * @param {bool} hasNewLine
         * @return {string} outputString
         */
        private static string OutputStringToConsole(string outputString, bool hasNewLine)
        {
            if (hasNewLine)
            {
                Console.WriteLine(outputString);
            }
            else
            {
                Console.Write(outputString);
            }

            return outputString;
        }
    }
}