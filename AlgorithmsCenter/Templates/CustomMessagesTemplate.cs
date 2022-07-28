#region Usings
using System;
using System.Collections.Generic;
#endregion

namespace AlgorithmsCenter.MessageTemplate
{
    public class CustomMessagesTemplate
    {
        #region Properties
        /// <summary>
        ///  List of all algorithms which app contains.
        /// </summary>
        protected List<string> AlogirthmsList = new List<string>();

        /// <summary>
        ///  Input for selected command.
        /// </summary>
        protected string input = "";

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
            Console.WriteLine("Test help");
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
            if(listToPrint.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("*******************************************************************\n" +
                    "************* There is none algorithms implemented yet ************\n" +
                    "*******************************************************************");
                Console.ResetColor();

                return;
            }
            foreach(string item in listToPrint)
            {
                Console.WriteLine($"-{item}");
            }
        }
        #endregion
    }
}
