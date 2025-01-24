using System;
using System.Windows.Forms;
using System.Timers;
namespace AdvancedPomodoroTimer
{
    public partial class PomodoroTimerForm : Form
    {
        private System.Timers.Timer timer;
        private int timeLeft;
        private bool isRunning;
        private int studyDuration;
        private int breakDuration;
        private const int ShortBreak = 5 * 60;  // 5 minutes in seconds
        private const int MediumBreak = 10 * 60; // 10 minutes in seconds
        private const int LongBreak = 15 * 60; // 15 minutes in seconds
        public PomodoroTimerForm()
        {
            this.Icon = new Icon("Resources\\timer.ico");
            InitializeComponent();
            timer = new System.Timers.Timer(1000); // 1-second intervals
            timer.Elapsed += Timer_Elapsed;
        }
        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                timer.Stop();
                btnStart.Text = "Start";
            }
            else
            {
                timeLeft = studyDuration;
                timer.Start();
                btnStart.Text = "Pause";
            }
            isRunning = !isRunning;
        }
        private void Timer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                UpdateTimerLabel();
            }
            else
            {
                timer.Stop();
                isRunning = false;
                Invoke(new Action(() =>
                {
                    btnStart.Text = "Start";
                    MessageBox.Show("Time's up!", "Pomodoro Timer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    StartBreak();
                }));
            }
        }
        private void StartBreak()
        {
            if (MessageBox.Show("Start break?", "Pomodoro Timer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                timeLeft = breakDuration;
                timer.Start();
                isRunning = true;
            }
        }
        private void BtnSetInterval_Click(object sender, EventArgs e)
        {
            string selectedInterval = cmbIntervals.SelectedItem?.ToString() ?? "";

            switch (selectedInterval)
            {
                case "25 Minutes Study (5 Min Break)":
                    studyDuration = 25 * 60;
                    breakDuration = ShortBreak;
                    break;
                case "30 Minutes Study (10 Min Break)":
                    studyDuration = 30 * 60;
                    breakDuration = MediumBreak;
                    break;
                case "45 Minutes Study (15 Min Break)":
                    studyDuration = 45 * 60;
                    breakDuration = LongBreak;
                    break;
                default:
                    studyDuration = 25 * 60;
                    breakDuration = ShortBreak;
                    break;
            }
            ResetTimer(studyDuration);
        }
        private void ResetTimer(int duration)
        {
            timeLeft = duration;
            isRunning = false;
            UpdateTimerLabel();
            btnStart.Text = "Start";
        }
        private void UpdateTimerLabel()
        {
            if (lblTimer.InvokeRequired)
            {
                lblTimer.Invoke(new Action(() => lblTimer.Text = FormatTime(timeLeft)));
            }
            else
            {
                lblTimer.Text = FormatTime(timeLeft);
            }
        }
        private string FormatTime(int seconds)
        {
            int minutes = seconds / 60;
            int remainingSeconds = seconds % 60;
            return $"{minutes:D2}:{remainingSeconds:D2}";
        }
    }
}