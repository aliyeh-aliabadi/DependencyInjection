using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class LogbySms : Aax_Logger.Ilog
    {
        public void log(string message)
        {
            //Send log by sms
            System.Windows.Forms.MessageBox.Show("Log was sent successfully");
        }
    }
}
