namespace AlgorithmsCenter.Algorithms
{
    #region Usings

    using AlgorithmsCenter.Templates;
    using System;
    using System.Collections.Generic;

    #endregion

    /// <summary>
    /// Implementation of Bubble Sort algorithm.
    /// </summary>
    public class BubbleSort : AlgorithmsTemplate
    {
        #region Fields and Variables

        /// <summary>
        /// Numbers to sort from user input.
        /// </summary>
        private List<int> numbersToSort = new List<int>();

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes object.
        /// </summary>
        public BubbleSort()
        {
            this.AlgorithmTitle = "Bubble sort";
            this.AlgorithmDescription = "Simplest sorting algorithm that works by repeatedly swapping the adjacent elements" +
                " if they are in the wrong order";
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the algorithm title.
        /// </summary>
        public string AlgorithmTitle { get; set; }

        /// <summary>
        /// Gets or sets the algorithm title.
        /// </summary>
        public string AlgorithmDescription { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Get number from user input.
        /// </summary>
        public void GetNumbersToSort()
        {
            int numberToInsert;

            while (!this.stopInsert)
            {
                string input = default;

                if (this.AlogirthmsList.Count > 2)
                {
                    Console.WriteLine("If You want to break type: stop");
                    input = Console.ReadLine();
                }
                if (input != "stop")
                {
                    while (numbersToSort.Count != 2)
                    {
                        Console.WriteLine("If You want to break type: stop");
                        Console.WriteLine("Please, insert the numbers to sort(at least 2): ");
                        input = Console.ReadLine();
                        if (input != "stop")
                        {
                            correctInput = int.TryParse(input, out numberToInsert);
                            if (!correctInput)
                            {
                                Console.WriteLine("Wrong input! You need to write a number!");
                            }
                            else
                            {
                                numbersToSort.Add(numberToInsert);
                            }
                            this.PrintList("Actual numbers: " + this.numbersToSort);
                        }
                        else
                        {
                            this.stopInsert = true;
                        }
                    }
                }
                this.stopInsert = true;
            }
        }
        #endregion
    }
}
