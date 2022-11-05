namespace AlgorithmsCenter.Templates
{
    #region Usings

    using AlgorithmsCenter.MessageTemplate;
    using System;
    using System.Collections.Generic;

    #endregion

    public abstract class AlgorithmsTemplate : CustomMessagesTemplate
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

        /// <summary>
        /// Numbers to sort from user input.
        /// </summary>
        protected List<int> numbersToSort = new List<int>();

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

        /// <summary>
        /// The run method.
        /// </summary>
        public abstract void Run();

        /// <summary>
        /// Get number from user input.
        /// </summary>
        protected void GetNumbersToSort()
        {
            int numberToInsert;
            string input = string.Empty;

            while (stopInsert != true)
            {
                Console.WriteLine("If You want to break type: stop");
                if (numbersToSort.Count < 2)
                {
                    Console.WriteLine("Please, insert the numbers to sort(at least 2): ");
                    this.PrintActualNumbersOnList();
                }
                Console.Write("Type number: ");
                input = Console.ReadLine();
                if (input != "stop")
                {
                    correctInput = int.TryParse(input, out numberToInsert);
                    if (!correctInput)
                    {
                        Console.WriteLine("Wrong input! You need to write a number!");
                        this.PrintActualNumbersOnList();
                    }
                    else
                    {
                        numbersToSort.Add(numberToInsert);
                        this.PrintActualNumbersOnList();
                    }
                }

                if (input == "stop")
                {
                    this.stopInsert = true;
                }
            }
        }

        /// <summary>
        /// Print list with data.
        /// </summary>
        protected void PrintList(List<int> listToPrint)
        {
            string output = string.Empty;

            //todo
            foreach(int item in listToPrint)
            {
                output += item + " ";
            }

            Console.WriteLine(output);
        }

        /// <summary>
        /// Print actual numbers on list.
        /// </summary>
        private void PrintActualNumbersOnList()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Actual numbers on list: ");
            this.PrintList(this.numbersToSort);
            Console.ResetColor();
        }

        #endregion
    }
}
