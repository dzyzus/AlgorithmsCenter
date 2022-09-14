#region Usings
using AlgorithmsCenter.Algorithms;
using AlgorithmsCenter.Controller;
#endregion

namespace AlgorithmsCenter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DefaultController defaultController = new DefaultController();

            defaultController.Run();
        }
    }
}
