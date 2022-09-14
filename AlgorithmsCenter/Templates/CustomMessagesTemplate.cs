#region Usings
using AlgorithmsCenter.Algorithms;
using AlgorithmsCenter.Templates;
using System;
using System.Collections.Generic;
#endregion

namespace AlgorithmsCenter.MessageTemplate
{
    public class CustomMessagesTemplate : AlgorithmsTemplate
    {
        #region Properties

        /// <summary>
        ///  Input for selected command.
        /// </summary>
        protected string input = "";

        /// <summary>
        ///  List of all algorithms which app contains.
        /// </summary>
        protected List<string> AlogirthmsList = new List<string>();

        #endregion

        #region Methods
        /// <summary>
        ///  Copyright info
        /// </summary>
        protected void CopyrightsInfo()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("*******************************************************************\n" +
                "**************** APP AND SOURCE CODE IS FULLY FREE ****************\n" +
                "********************** AUTHOR: MACIEJ MARZEC **********************\n" +
                "*******************************************************************");
            Console.ResetColor();
        }

        /// <summary>
        ///  Welcome message on app start
        /// </summary>
        protected void WelcomeMessage()
        {
            Console.WriteLine("*******************************************************************\n" +
                "************************ ALGORITHMS CENTER ************************\n" +
                "***************************** WELCOME *****************************\n" +
                "*******************************************************************");
        }

        /// <summary>
        ///  Basic info about app
        /// </summary>
        protected void BasicInfo()
        {
            Console.WriteLine("*******************************************************************\n" +
                "***** At this moment u can try and review code for algorithms *****\n" +
                "*******************************************************************");

            PrintList(this.AlogirthmsList);
        }

        /// <summary>
        ///  Information with more specific commands
        /// </summary>
        protected void HelpInfo()
        {
            Console.WriteLine("*******************************************************************\n" +
                "-fibonacci for fibonacci algorithm\n" +
                "-back go back to previously menu\n" +
                "*******************************************************************");
        }

        /// <summary>
        ///  Information about app
        /// </summary>
        protected void AppDescription()
        {
            Console.WriteLine("Test description");
        }
        /// <summary>
        ///  Information about basic commands
        /// </summary>
        protected virtual void BasicCommands()
        {
            Console.WriteLine("*******************************************************************\n" +
                "-help for more information\n" +
                "-description for more information about app\n" +
                "-quit for exit app\n" +
                "*******************************************************************");
        }
        /// <summary>
        ///  Display list of available algorithms
        /// </summary>
        private void PrintList(List<string> listToPrint)
        {
            FillAlgorithmsList();

            if(listToPrint.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("*******************************************************************\n" +
                    "************* There is none algorithms implemented yet ************\n" +
                    "*******************************************************************");
                Console.ResetColor();

                return;
            }
            Console.WriteLine("*******************************************************************");
            foreach (string item in listToPrint)
            {
                //TODO
                //Count number of letters and print equal numbers of *
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"-- {item}");
                Console.ResetColor();

            }
            Console.WriteLine("*******************************************************************");

        }
        private void FillAlgorithmsList()
        {
            //TODO
            //make object re-usage
            FibonacciNumbers fibonacciNumbers = new FibonacciNumbers();
            AlogirthmsList.Add(fibonacciNumbers.FibonacciNumbersTitle);
        }
        #endregion
    }
}
