namespace Aax_Logger
{
    public class LogToDatabase : Ilog
    {
        public void log(string message)
        {
            //Insert log into Db
            System.Windows.Forms.MessageBox.Show("Log was inserted successfully into Db");
        }
    }
}
