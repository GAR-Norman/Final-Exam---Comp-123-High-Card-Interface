using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Gabriel Norman 
 * Student #: 300897331
 * Date: August 17, 2017 
 * Description: This is the driver class
 * Version: 0.1 - Initial Commit - Finished Splashform
*/

namespace Final_Exam___Comp_123_High_Card_Interface
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static PickHighestCardForm newHighCardForm;

    [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            newHighCardForm = new PickHighestCardForm();

            Application.Run(new SplashForm());
            Application.Run(newHighCardForm);
        }
    }
}
