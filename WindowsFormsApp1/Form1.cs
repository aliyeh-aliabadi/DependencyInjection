using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Aax_Logger.LogToDatabase oLogger = new Aax_Logger.LogToDatabase();

            LogbySms oLogger = new LogbySms();

            Aax_Logger.LogHandler oLogHandler = new Aax_Logger.LogHandler(oLogger);

            oLogHandler.log("message");
        }
    }
}
