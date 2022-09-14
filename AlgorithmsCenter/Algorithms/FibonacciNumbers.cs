using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCenter.Algorithms
{
    public class FibonacciNumbers
    {
        #region Fields and variables

        /// <summary>
        /// Name of algorithm
        /// </summary>
        private string AlgorithmName = "Fibonacci numbers";

        /// <summary>
        /// Description of algorithm
        /// </summary>
        private string DescriptionOfAlgorithm = "First number is equal 0, second 1, every next is sum of two previously";

        #endregion

        #region properties

        /// <summary>
        /// Input number to check if it is Fibonacci number
        /// </summary>
        protected string NumberToCheck { get; set; }
        #endregion

        #region methods
        public void int GetFibonacciNumber()
        {
            int fibonacciNumber;
            Console.WriteLine("Please, insert the number which u want to check:");
            try
            {
                NumberToCheck = Console.ReadLine();
                NumberToCheck = int.TryParse(NumberToCheck, out fibonacciNumber);
            }
        }
        public void FibonacciAlgorithm
        {

        }

        #endregion
    }
}
