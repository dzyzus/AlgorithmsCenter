#region Usings
using AlgorithmsCenter.Algorithms;
using AlgorithmsCenter.MessageTemplate;
using System;
#endregion

namespace AlgorithmsCenter.Controller
{
    public class DefaultController : CustomMessagesTemplate
    {
        #region Fields and variables

        public FibonacciNumbers fibonacciNumbers { get; set; }

        /// <summary>
        /// if true, program is still runing
        /// </summary>
        private bool loopContinue = true;

        #endregion

        #region Constructor

        /// <summary>
        /// Object constructor
        /// </summary>
        public DefaultController()
        {
            this.fibonacciNumbers = new FibonacciNumbers();
        }

        #endregion

        /// <summary>
        /// Primary run app method
        /// </summary>
        public virtual void Run()
        {
            CopyrightsInfo();
            WelcomeMessage();
            BasicInfo();
            BasicCommands();
        }
        /// <summary>
        /// Catching basic commands
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
                        this.fibonacciNumbers.CheckIfNumberIsFibonacciNumbers();
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
    }
}
