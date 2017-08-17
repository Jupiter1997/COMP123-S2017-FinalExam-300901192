using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Marvin Jupiter Vargas
 * Student No.: 300901192
 * Date: August 17, 2017
 * Description: This is the Splash screen form the will show up first when starting
 * the program and wil the Main form after 3 seconds
 * Version 0.1: Added a public static variable for splash screen
 */

namespace COMP123_S2017_FinalExam_300901192
{
    public static class Program
    {
        //for Instantiation
        public static PickHighestCardForm pickHighCard;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            pickHighCard = new PickHighestCardForm();
            Application.Run(new SplashForm());
        }
    }
}
