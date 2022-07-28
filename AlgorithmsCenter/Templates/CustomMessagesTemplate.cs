#region Usings
using System;
using System.Collections.Generic;
#endregion

namespace AlgorithmsCenter.MessageTemplate
{
    public class CustomMessagesTemplate
    {
        List<string> AlogirthmsList = new List<string>();

        /// <summary>
        ///  Copyrights info
        /// </summary>
        protected void CopyrightsInfo()
        {

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
    }
}
