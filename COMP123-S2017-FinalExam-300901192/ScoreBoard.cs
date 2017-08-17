using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
 * Name: Marvin Jupiter Vargas
 * Student No.: 300901192
 * App Name: Pick the Highest Card Game
 * Date: August 17, 2017
 * Description: This will the keep track of the Score in the main form
 * Version 0.1: Created Scoreboard Class
 */
namespace COMP123_S2017_FinalExam_300901192
{
    // This is the ScoreBoard Class
    public class ScoreBoard 
    {
        

        //Private Instance Variable
        private TextBox _finalScoreTextBox;
        private int _score;
        private TextBox _scoreTextBox;
        private int _time;
        private TextBox _timeTextBox;

        //Public Properties
        public TextBox FinalScoreTextBox
        {
            get
            {
                return this._finalScoreTextBox;
            }
            set
            {
                this.FinalScoreTextBox.Text = _score.ToString();
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
                this.ScoreTextBox.Text = Convert.ToString(this._score);
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
                this._scoreTextBox = value;
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
                this.TimeTextBox.Text = _time.ToString();
            }
        }
        public TextBox TimeTextBox
        {
            get
            {
                return this._timeTextBox;
            }
            set
            {
                this._timeTextBox = value;
            }
        }/// <summary>
         /// This is the Contructer that sets up the ScoreBoard Class
         /// it has three parameter : scoreText ,BoxtimeTextBox ,finalScoreTextBox
         /// </summary>
         /// <param name="scoreTextBox"></param>
         /// <param name="timeTextBox"></param>
         /// <param name="finalScoreTextBox"></param>
        public ScoreBoard (TextBox scoreTextBox, TextBox timeTextBox, TextBox finalScoreTextBox)
        {
            this.ScoreTextBox = scoreTextBox;
            this.TimeTextBox = timeTextBox;
            this.FinalScoreTextBox = finalScoreTextBox;
        }
        /// <summary>
        /// This is the UpdateTime it update the time every scene
        /// </summary>
        public void UpdateTime()
        {
            int txtboxTime = Convert.ToInt32(TimeTextBox.Text);
            Time = txtboxTime -1;
            TimeTextBox.Text = Time.ToString();

        }


    }
}