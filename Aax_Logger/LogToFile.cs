namespace Aax_Logger
{
    public class LogToFile : Ilog
    {
        public void log(string message)
        {
            //Insert log into file
            System.Windows.Forms.MessageBox.Show("Log was inserted successfully into File");
        }
    }
}
