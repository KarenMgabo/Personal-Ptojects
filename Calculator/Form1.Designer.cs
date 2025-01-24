namespace calculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn0;
        private System.Windows.Forms.Button btnplus, btnmin, btnmul, btndiv, btneql, btnclear;
        private System.Windows.Forms.Button btnsqrt, btnsquare, btnlog, btnsin, btncos, btntan;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            SuspendLayout();

            // TextBox
            txtTotal = new System.Windows.Forms.TextBox();
            txtTotal.Location = new System.Drawing.Point(20, 20);
            txtTotal.Size = new System.Drawing.Size(340, 30);
            txtTotal.Text = "0";
            txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // Buttons
            btn1 = CreateButton("1", 20, 70, btn1_Click);
            btn2 = CreateButton("2", 80, 70, btn2_Click);
            btn3 = CreateButton("3", 140, 70, btn3_Click);
            btn4 = CreateButton("4", 20, 120, btn4_Click);
            btn5 = CreateButton("5", 80, 120, btn5_Click);
            btn6 = CreateButton("6", 140, 120, btn6_Click);
            btn7 = CreateButton("7", 20, 170, btn7_Click);
            btn8 = CreateButton("8", 80, 170, btn8_Click);
            btn9 = CreateButton("9", 140, 170, btn9_Click);
            btn0 = CreateButton("0", 20, 220, btn0_Click);

            btnplus = CreateButton("+", 200, 70, btnplus_Click);
            btnmin = CreateButton("-", 200, 120, btnmin_Click);
            btnmul = CreateButton("*", 200, 170, btnmul_Click);
            btndiv = CreateButton("/", 200, 220, btndiv_Click);
            btneql = CreateButton("=", 260, 220, btneql_Click);
            btnclear = CreateButton("C", 260, 70, btnclear_Click);

            // Scientific Buttons
            btnsqrt = CreateButton("√", 260, 120, btnsqrt_Click);
            btnsquare = CreateButton("^2", 320, 120, btnsquare_Click);
            btnlog = CreateButton("log", 260, 170, btnlog_Click);
            btnsin = CreateButton("sin", 320, 70, btnsin_Click);
            btncos = CreateButton("cos", 320, 170, btncos_Click);
            btntan = CreateButton("tan", 320, 220, btntan_Click);

            // Adding controls
            Controls.Add(txtTotal);
            Controls.AddRange(new System.Windows.Forms.Control[]
            {
                btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn0,
                btnplus, btnmin, btnmul, btndiv, btneql, btnclear,
                btnsqrt, btnsquare, btnlog, btnsin, btncos, btntan
            });

            // Form setup
            ClientSize = new System.Drawing.Size(400, 300);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button CreateButton(string text, int x, int y, EventHandler handler)
        {
            var button = new Button();
            button.Text = text;
            button.Location = new System.Drawing.Point(x, y);
            button.Size = new System.Drawing.Size(50, 40);
            button.Click += handler;
            return button;
        }
    }
}
