using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 * Name: Gabriel Norman 
 * Student #: 300897331
 * Date: August 17, 2017 
 * Description: This is the scoreboard class class
 * Version: 0.1 - Finished Splashform
*/
namespace Final_Exam___Comp_123_High_Card_Interface
{
    public class ScoreBoard
    {
        //private instance variables 

        private string _finalScoreTextBox;

        private int _score;

        private string _scoreTextBox;

        private int _time;

        private string _timeTextBox;
        //Public Properties 

        public TextBox FinalScoreTextBox
        {
            get
            {
                
            }
            set
            {

            }
        }

        public int Score
        {
            get
            {
                return this._score;
            }

            set
            {
                ScoreTextBox = Convert.ToString(value);
                FinalScoreTextBox = Convert.ToString(value);
            }
        }


        public TextBox ScoreTextBox
        {
            get
            {
                return this._scoreTextBox;

            }

            set
            {
                string conversion = Convert.ToString(this._scoreTextBox);
                conversion = value;
            }
        }


        public int Time
        {
            get
            {
                return this._time;

            }

            set
            {
                this.TimeTextBox = Convert.ToString(this._time);
            }
        }

        public TextBox TimeTextBox
        {

            get
            {

                string conversion = Convert.ToString(this._time);
                return conversion;
            }

            set
            {

            }
        }

        // methods 

        public void ScoreBoard(TextBox ScoreTextBox, TextBox TimeTextbox, TextBox FinalScoreTextbox  )
        {

        }
    } 
}
