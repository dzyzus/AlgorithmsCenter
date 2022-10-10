using AlgorithmsCenter.MessageTemplate;

namespace AlgorithmsCenter.Templates
{
    public class AlgorithmsTemplate : CustomMessagesTemplate
    {
        #region Fields and variables

        #endregion

        #region properties

        /// <summary>
        /// Name of algorithm.
        /// </summary>
        protected string AlgorithmTitle { get; set; }

        /// <summary>
        /// Description of algorithm.
        /// </summary>
        protected string AlgorithmDescription { get; set; }

        /// <summary>
        /// Path to plain text.
        /// </summary>
        protected string PlainTextPath { get; set; }

        /// <summary>
        /// Path to encrypt text save.
        /// </summary>
        protected string EncryptTextPath { get; set; }

        /// <summary>
        /// Path to decrypt text save.
        /// </summary>
        protected string DecrypteTextPath { get; set; }

        #endregion

        #region methods

        #endregion
    }
}
