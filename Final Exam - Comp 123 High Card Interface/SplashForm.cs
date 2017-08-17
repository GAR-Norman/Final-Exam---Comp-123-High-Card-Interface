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
 * Name: Gabriel Norman 
 * Student #: 300897331
 * Date: August 17, 2017 
 * Description: This is the splash form
 * Version: 0.1 - Initial Commit
*/ 

namespace Final_Exam___Comp_123_High_Card_Interface
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        //Public Properties
        public PickHighestCardForm highCard
        {
            get
            {
                return Program.newHighCardForm;
            }
        }

        //Private Methods
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            this.highCard.Show();
            this.Hide();
            SplashTimer.Enabled = false;
        }
    }
    }

