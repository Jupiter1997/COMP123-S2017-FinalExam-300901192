using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name: Marvin Jupiter Vargas
 * Student No.: 300901192
 * Date: August 17, 2017
 * Description: This is the Splash screen form the will show up first when starting
 * the program and wil the Main form after 3 seconds
 *  Version 0.1: added a public property
 */

namespace COMP123_S2017_FinalExam_300901192
{
    public partial class SplashForm : Form
    {
        //Public Properties
        public PickHighestCardForm PickHighCardForm
        {
            get
            {
                return Program.pickHighCard;
            }
        }
            
        public SplashForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This iss the times that will count three seconds to "load" the PickHighestCardForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashScreenTimer_Tick(object sender, EventArgs e)
        {
            this.PickHighCardForm.Show();
            this.Hide();
            SplashScreenTimer.Enabled = false;

        }
    }
}
