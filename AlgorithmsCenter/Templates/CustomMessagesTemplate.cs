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
        List<string> AlogirthmsList = new List<string>();

        /// <summary>
        ///  Get current background console color.
        /// </summary>
        ConsoleColor background = Console.BackgroundColor;

        /// <summary>
        ///  Get current foreground console color.
        /// </summary>
        ConsoleColor foreground = Console.ForegroundColor;

        #endregion

        #region Methods
        /// <summary>
        ///  Copyrights info
        /// </summary>
        protected void CopyrightsInfo()
        {
            Console.WriteLine("*******************************************************************\n" +
                "**************** APP AND SOURCE CODE IS FULLY FREE ****************\n" +
                "********************** AUTHOR: MACIEJ MARZEC **********************\n" +
                "*******************************************************************");
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
        private void PrintList(List<string> listToPrint)
        {
            if(listToPrint.Count == 0)
            {
                Console.Write("************* There is none algorithms implemented yet ************\n" +
                    "*******************************************************************");
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
