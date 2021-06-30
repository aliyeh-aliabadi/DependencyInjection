namespace Aax_Logger
{
    public class LogHandler : System.Object
    {
        public LogHandler(Ilog log)
        {
            logger = log;
        }

        public Ilog logger { get; set; }

        public void log(string message)
        {
            logger.log(message);
        }
    }
}
