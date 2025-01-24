namespace AdvancedPomodoroTimer
{
    partial class PomodoroTimerForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTimer;
        private Button btnStart;
        private ComboBox cmbIntervals;
        private Button btnSetInterval;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.cmbIntervals = new System.Windows.Forms.ComboBox();
            this.btnSetInterval = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // lblTimer
            this.lblTimer.Text = "00:00";
            this.lblTimer.Font = new System.Drawing.Font("Cambria", 24F);
            this.lblTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // btnStart
            this.btnStart.Text = "Start";
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);

            // cmbIntervals
            this.cmbIntervals.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbIntervals.Items.AddRange(new object[] {
                "25 Minutes Study (5 Min Break)",
                "30 Minutes Study (10 Min Break)",
                "45 Minutes Study (15 Min Break)"
            });
            this.cmbIntervals.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // btnSetInterval
            this.btnSetInterval.Text = "Set Interval";
            this.btnSetInterval.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetInterval.Click += new System.EventHandler(this.BtnSetInterval_Click);

            // PomodoroTimerForm
            this.Text = "Advanced Pomodoro Timer";
            this.Size = new System.Drawing.Size(300, 200);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSetInterval);
            this.Controls.Add(this.cmbIntervals);
            this.Controls.Add(this.lblTimer);

            this.ResumeLayout(false);
        }
    }
}
