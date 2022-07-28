#region Usings
using AlgorithmsCenter.MessageTemplate;
#endregion

namespace AlgorithmsCenter.Controller
{
    public class DefaultController : CustomMessagesTemplate
    {
        /// <summary>
        /// Object constructor
        /// </summary>
        public DefaultController()
        {
            //Constructor
        }

        /// <summary>
        /// Primary run app method
        /// </summary>
        public virtual void Run()
        {
            CopyrightsInfo();
            WelcomeMessage();
            BasicInfo();
        }
    }
}
