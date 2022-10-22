namespace AlgorithmsCenter.Algorithms
{
    #region Usings

    using AlgorithmsCenter.Templates;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    #endregion

    /// <summary>
    /// Implementation of Fibonacci Numbers algorithm.
    /// </summary>
    public class FibonacciNumbers : AlgorithmsTemplate
    {
        #region Fields and Variables

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
                Console.WriteLine("That number belongs tu Fibonacci Numbers!\n");
                return;
            }
            else
            {
                Console.WriteLine("Oops! That number does not exist on Fibonacci Numbers list\n");
                return;
            }
        }

        /// <summary>
        /// Get number from user input.
        /// </summary>
        private int GetFibonacciNumber()
        {
            int fibonacciNumber = 0;

            while (!this.correctInput)
            {
                Console.Write("Please, insert the number which u want to check: ");
                string numberToCheck = Console.ReadLine();
                this.correctInput = int.TryParse(numberToCheck, out fibonacciNumber);
                if (!this.correctInput)
                {
                    Console.WriteLine("Wrong input! You need to write a number!");
                }
            }

            return fibonacciNumber;
        }

        /// <summary>
        /// Fibonacci algorithm.
        /// Fill up list with fibonacci numbers.
        /// </summary>
        private void FibonacciAlgorithm()
        {
            this.NumberToCheck = GetFibonacciNumber();

            while (FibonacciNumbersHelper.Last() <= this.NumberToCheck)
            {
                int lastNumberOnList = this.FibonacciNumbersHelper.Count();
                this.FibonacciNumbersHelper.Add(
                    (this.FibonacciNumbersHelper[lastNumberOnList - 1] + this.FibonacciNumbersHelper[lastNumberOnList - 2]));
            }
        }

        #endregion
    }
}
