namespace AlgorithmsCenter.Algorithms
{
    #region Usings

    using AlgorithmsCenter.Templates;
    using System;
    using System.Diagnostics;

    #endregion

    /// <summary>
    /// Implementation of Bubble Sort algorithm.
    /// </summary>
    public class BubbleSort : AlgorithmsTemplate
    {
        #region Constructor

        /// <summary>
        /// Initializes object.
        /// </summary>
        public BubbleSort()
        {
            this.AlgorithmTitle = "Bubble Sort";
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
        /// The run method.
        /// </summary>
        public override void Run()
        {
            this.GetNumbersToSort();
            Console.WriteLine("Start bubble sort algorithm");
            this.BubbleSortAlgorithm();
            Console.WriteLine("Sorted numbers: ");
            this.PrintList(this.numbersToSort);
        }

        /// <summary>
        /// Bubble sort algorithm implementation.
        /// </summary>
        private void BubbleSortAlgorithm()
        {
            int temp;
            int count = this.numbersToSort.Count;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            while (count > 1)
            {
                for (int i = 0; i < count - 1; i++)
                {
                    if (numbersToSort[i] > numbersToSort[i + 1])
                    {
                        temp = numbersToSort[i + 1];
                        numbersToSort[i + 1] = numbersToSort[i];
                        numbersToSort[i] = temp;
                    }
                }

                count = count - 1;
            }

            stopwatch.Stop();
            Console.WriteLine($"Algorithm takes: {stopwatch.Elapsed.TotalMilliseconds} ms");
        }
       
    }
    #endregion
}