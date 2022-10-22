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
            input = Console.ReadLine();
            while (loopContinue)
            {
                switch (input)
                {
                    case "-help":
                        AlgorithmsCommands();
                        Console.Write("Type command: ");
                        input = Console.ReadLine();
                        break; ;
                    case "-description":
                        AppDescription();
                        Console.Write("Type command: ");
                        input = Console.ReadLine();
                        break;
                    case "-quit":
                        loopContinue = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect command!\n");
                        Console.Write("Type command: ");
                        input = Console.ReadLine();
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
            input = Console.ReadLine();
            while (loopContinue)
            {
                switch (input)
                {
                    case "-fibonacci":
                        this.FibonacciNumbers.CheckIfNumberIsFibonacciNumbers();
                        loopContinue = false;
                        break;
                    case "-back":
                        loopContinue = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect command!\n");
                        Console.Write("Type command: ");
                        input = Console.ReadLine();
                        break;
                }
            }

            loopContinue = true;
            BasicCommands();
        }

        /// <summary>
        /// Fill algorithms list.
        /// </summary>
        protected void FillAlgorithmsList()
        {
            this.AlogirthmsList.Add(FibonacciNumbers.AlgorithmTitle);
        }

        #endregion
    }
}
