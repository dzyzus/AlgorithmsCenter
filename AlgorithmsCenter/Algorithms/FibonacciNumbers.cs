namespace AlgorithmsCenter.Algorithms
{
    #region Usings

    using AlgorithmsCenter.Templates;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    #endregion

    public class FibonacciNumbers : AlgorithmsTemplate
    {
        #region Fields and Variables

        /// <summary>
        /// Used to chceck user input.
        /// </summary>
        private bool correctInput = false;

        /// <summary>
        /// First numbers of Fibonacci.
        /// </summary>
        private List<int> FibonacciNumbersHelper = new List<int> { 0, 1, 1 };
        #endregion

        #region Constructor

        /// <summary>
        /// Initializes object.
        /// </summary>
        public FibonacciNumbers()
        {
            this.AlgorithmTitle = "Fibonacci Numbers";
            this.AlgorithmDescription = "First number is equal 0, second 1, every next is sum of two previously";
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

        /// <summary>
        /// Gets or sets the input number to check if it is Fibonacci number.
        /// </summary>
        protected int NumberToCheck { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Check if number from user input belongs to Fibonacci Numbers.
        /// </summary>
        public void CheckIfNumberIsFibonacciNumbers()
        {
            FibonacciAlgorithm();

            if (FibonacciNumbersHelper.Contains(NumberToCheck))
            {
                Console.WriteLine("That number belongs tu Fibonacci Numbers!");
                return;
            }
            else
            {
                Console.WriteLine("Oops! That number does not exist on Fibonacci Numbers list");
                return;
            }
        }

        /// <summary>
        /// Get number from user input.
        /// </summary>
        private int GetFibonacciNumber()
        {
            int fibonacciNumber = 0;

            while (!correctInput)
            {
                Console.Write("Please, insert the number which u want to check: ");
                string numberToCheck = Console.ReadLine();
                correctInput = int.TryParse(numberToCheck, out fibonacciNumber);
                if (!correctInput)
                    Console.WriteLine("Wrong input! You need to write a number!");
            }

            return fibonacciNumber;
        }

        /// <summary>
        /// Fibonacci algorithm.
        /// Fill up list with fibonacci numbers.
        /// </summary>
        private void FibonacciAlgorithm()
        {
            NumberToCheck = GetFibonacciNumber();

            while (FibonacciNumbersHelper.Last() <= NumberToCheck)
            {
                int lastNumberOnList = FibonacciNumbersHelper.Count();
                FibonacciNumbersHelper.Add((FibonacciNumbersHelper[lastNumberOnList - 1] + FibonacciNumbersHelper[lastNumberOnList - 2]));
            }
        }

        #endregion
    }
}
