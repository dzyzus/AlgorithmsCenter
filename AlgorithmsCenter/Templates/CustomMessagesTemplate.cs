﻿#region Usings
using AlgorithmsCenter.Algorithms;
using System;
using System.Collections.Generic;
#endregion

namespace AlgorithmsCenter.MessageTemplate
{
    public class CustomMessagesTemplate
    {
        #region Properties

        /// <summary>
        /// Input for selected command.
        /// </summary>
        protected string input = "";

        /// <summary>
        /// List of all algorithms which app contains.
        /// </summary>
        protected List<string> AlogirthmsList = new List<string>();

        /// <summary>
        /// Count stars on the left.
        /// </summary>
        private int leftStars = 0;

        /// <summary>
        /// Count stars on the right.
        /// </summary>
        private int rightStars = 0;
        #endregion

        #region Methods
        /// <summary>
        /// Copyright info.
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
        /// Welcome message on app start.
        /// </summary>
        protected void WelcomeMessage()
        {
            Console.WriteLine("*******************************************************************\n" +
                "************************ ALGORITHMS CENTER ************************\n" +
                "***************************** WELCOME *****************************\n" +
                "*******************************************************************");
        }

        /// <summary>
        /// Basic info about app.
        /// </summary>
        protected void BasicInfo()
        {
            Console.WriteLine("*******************************************************************\n" +
                "***** At this moment u can try and review code for algorithms *****\n" +
                "*******************************************************************");

            PrintList(this.AlogirthmsList);
        }

        /// <summary>
        /// Information with more specific commands.
        /// </summary>
        protected void HelpInfo()
        {
            Console.WriteLine("*******************************************************************\n" +
                "-fibonacci for fibonacci algorithm\n" +
                "-back go back to previously menu\n" +
                "*******************************************************************");
        }

        /// <summary>
        /// Information about app.
        /// </summary>
        protected void AppDescription()
        {
            Console.WriteLine("Test description");
        }

        /// <summary>
        /// Information about basic commands.
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
        /// Fill algorithms list.
        /// </summary>
        protected void FillAlgorithmsList(string algorithm)
        {
            AlogirthmsList.Add(algorithm);
        }

        /// <summary>
        /// Display list of available algorithms.
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
            Console.WriteLine("*******************************************************************");
            foreach (string item in listToPrint)
            {
                this.CountHowManyStars(item);
                string left = new string('*', leftStars);
                string right = new string('*', rightStars);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"{left} {item} {right}");
                Console.ResetColor();

            }
            Console.WriteLine("*******************************************************************");

        }

        /// <summary>
        /// Count how many stars is to print.
        /// </summary>
        /// <param name="word">
        /// Count chars in given word.
        /// </param>
        private void CountHowManyStars(string word)
        {
            const int stars = 68;
            const int twoSide = 2;
            const int starsForSide = stars / 2;
            const int rightSideLess = 1;
            const int space = 1;
            int count = word.Length;

            if(count % 2 == 0)
            {
                rightStars = starsForSide - (count/twoSide) - space;
                leftStars = rightStars - space;
            }
            else
            {
                rightStars = starsForSide - (count/twoSide) - space;
                leftStars = rightStars - rightSideLess - space;
            }
        }
        #endregion
    }
}
