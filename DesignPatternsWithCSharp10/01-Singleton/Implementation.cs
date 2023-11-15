namespace Singleton
{
    /// <summary>
    /// Singleton Class
    /// </summary>
    public class Logger
    {
        /// <summary>
        /// Backing field for the Instance property
        /// </summary>
        // private static Logger? _instance;

        private static Lazy<Logger?> _lazyInstance = new Lazy<Logger?>(() => new Logger());

        /// <summary>
        ///  protected or private constructor 
        /// </summary>
        protected Logger()
        {}

        /// <summary>
        /// Public property for accessing the singleton instance
        /// </summary>
        public static Logger? Instance
        {
            get 
            { 
                //if (_instance == null)
                //{
                //    _instance = new Logger();
                //}
                //return _instance;

                return _lazyInstance.Value;
            }
        }

        public void Log(string message) 
        {
            Console.WriteLine(message);
        }
    }

}
