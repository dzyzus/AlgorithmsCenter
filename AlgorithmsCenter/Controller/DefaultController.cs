namespace AlgorithmsCenter.Controller
{
    #region Usings

    using AlgorithmsCenter.Algorithms;
    using AlgorithmsCenter.MessageTemplate;
    using System;

    #endregion

    public class DefaultController : CustomMessagesTemplate
    {
        #region Fields and variables

        /// <summary>
        /// if true, program is still runing
        /// </summary>
        private bool loopContinue = true;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the FibonacciNumbers algorithm.
        /// </summary>
        public FibonacciNumbers FibonacciNumbers
        {
            get
            { 
                return new FibonacciNumbers(); 
            }
        }

        /// <summary>
        /// Gets or sets the BubbleSort algorithm.
        /// </summary>
        public BubbleSort BubbleSort
        {
            get
            {
                return new BubbleSort();
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Primary run app method.
        /// </summary>
        public virtual void Run()
        {
            this.CopyrightsInfo();
            this.FillAlgorithmsList();
            this.WelcomeMessage();
            this.BasicInfo();
            this.BasicCommands();
        }

        /// <summary>
        /// Basic commands.
        /// </summary>
        protected override void BasicCommands()
        {
            base.BasicCommands();
            Console.Write("Type command: ");
            this.input = Console.ReadLine();
            while (this.loopContinue)
            {
                switch (this.input)
                {
                    case "-help":
                        AlgorithmsCommands();
                        Console.Write("Type command: ");
                        this.input = Console.ReadLine();
                        break; ;
                    case "-description":
                        AppDescription();
                        Console.Write("Type command: ");
                        this.input = Console.ReadLine();
                        break;
                    case "-quit":
                        this.loopContinue = false;
                        break;
                    default:
                        Console.WriteLine("\nIncorrect command!\n");
                        Console.Write("Type command: ");
                        this.input = Console.ReadLine();
                        break; ;
                }
            }
        }

        /// <summary>
        /// Algorithms commands.
        /// </summary>
        private void AlgorithmsCommands()
        {
            HelpInfo();
            Console.Write("Type command: ");
            this.input = Console.ReadLine();
            while (this.loopContinue)
            {
                switch (input)
                {
                    case "-fibonacci":
                        this.AlgorithmInformations(this.FibonacciNumbers.AlgorithmDescription);
                        this.FibonacciNumbers.Run();
                        this.loopContinue = false;
                        break;
                    case "-bubblesort":
                        this.AlgorithmInformations(this.BubbleSort.AlgorithmDescription);
                        this.BubbleSort.Run();
                        this.loopContinue = false;
                        break;
                    case "-back":
                        this.loopContinue = false;
                        break;
                    default:
                        Console.WriteLine("\nIncorrect command!\n");
                        Console.Write("Type command: ");
                        this.input = Console.ReadLine();
                        break;
                }
            }

            this.loopContinue = true;
            this.BasicCommands();
        }

        /// <summary>
        /// Fill algorithms list.
        /// </summary>
        protected void FillAlgorithmsList()
        {
            this.AlogirthmsList.Add(this.BubbleSort.AlgorithmTitle);
            this.AlogirthmsList.Add(FibonacciNumbers.AlgorithmTitle);
        }

        #endregion
    }
}
