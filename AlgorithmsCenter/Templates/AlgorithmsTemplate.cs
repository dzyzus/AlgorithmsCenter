namespace AlgorithmsCenter.Templates
{
    #region Usings

    using AlgorithmsCenter.MessageTemplate;
    using System;
    using System.Collections.Generic;

    #endregion

    public class AlgorithmsTemplate : CustomMessagesTemplate
    {
        #region Fields and variables

        /// <summary>
        /// False until user decide to stop insert numbers.
        /// </summary>
        protected bool stopInsert = false;

        /// <summary>
        /// False until user decide to stop insert numbers.
        /// </summary>
        protected bool correctInput = false;

        #endregion

        #region properties

        /// <summary>
        /// Gets or sets path to plain text.
        /// </summary>
        protected string PlainTextPath { get; set; }

        /// <summary>
        /// Gets or sets path to encrypt text save.
        /// </summary>
        protected string EncryptTextPath { get; set; }

        /// <summary>
        /// Gets or sets path to decrypt text save.
        /// </summary>
        protected string DecrypteTextPath { get; set; }

        #endregion

        #region Methods

        protected void PrintList(List<int> listToPrint)
        {
            int count = listToPrint.Count;
            string output = string.Empty;

            //todo
            foreach(int item in listToPrint)
            {
                if (listToPrint.Count == 1)
                    Console.Write(item);
                else
                    if (listToPrint[count] != item)
                        Console.WriteLine(item + ", ");
                    else
                        Console.WriteLine(item);
            }
        }

        #endregion
    }
}
