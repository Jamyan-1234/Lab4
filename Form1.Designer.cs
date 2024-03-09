namespace Lab4
{
    partial class frmCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtValue = new TextBox();
            btnBackspace = new Button();
            btnCE = new Button();
            btnCLear = new Button();
            btnMemoryClear = new Button();
            btnMemoryRecall = new Button();
            btnMemorySave = new Button();
            btnMemoryPlus = new Button();
            btnDivide = new Button();
            btnMultiple = new Button();
            btnSubtrac = new Button();
            btnPlus = new Button();
            btnSqrt = new Button();
            btnPercent = new Button();
            btnOneOverX = new Button();
            btnEquals = new Button();
            btnPlusMinis = new Button();
            btnPeriod = new Button();
            Btn0 = new Button();
            Btn1 = new Button();
            Btn2 = new Button();
            Btn3 = new Button();
            Btn4 = new Button();
            Btn5 = new Button();
            Btn6 = new Button();
            Btn7 = new Button();
            Btn8 = new Button();
            Btn9 = new Button();
            SuspendLayout();
            // 
            // txtValue
            // 
            txtValue.Location = new Point(93, 60);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(261, 27);
            txtValue.TabIndex = 0;
            txtValue.TabStop = false;
            txtValue.Text = "0.";
            txtValue.TextAlign = HorizontalAlignment.Right;
            txtValue.TextChanged += txtValue_TextChanged;
            // 
            // btnBackspace
            // 
            btnBackspace.Location = new Point(84, 103);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(89, 29);
            btnBackspace.TabIndex = 1;
            btnBackspace.Text = "Backspace";
            btnBackspace.UseVisualStyleBackColor = true;
            // 
            // btnCE
            // 
            btnCE.Location = new Point(179, 103);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(89, 29);
            btnCE.TabIndex = 2;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            // 
            // btnCLear
            // 
            btnCLear.Location = new Point(274, 103);
            btnCLear.Name = "btnCLear";
            btnCLear.Size = new Size(89, 29);
            btnCLear.TabIndex = 3;
            btnCLear.Text = "C";
            btnCLear.UseVisualStyleBackColor = true;
            // 
            // btnMemoryClear
            // 
            btnMemoryClear.Location = new Point(2, 148);
            btnMemoryClear.Name = "btnMemoryClear";
            btnMemoryClear.Size = new Size(84, 29);
            btnMemoryClear.TabIndex = 4;
            btnMemoryClear.Text = "MC";
            btnMemoryClear.UseVisualStyleBackColor = true;
            // 
            // btnMemoryRecall
            // 
            btnMemoryRecall.Location = new Point(2, 183);
            btnMemoryRecall.Name = "btnMemoryRecall";
            btnMemoryRecall.Size = new Size(84, 29);
            btnMemoryRecall.TabIndex = 5;
            btnMemoryRecall.Text = "MR";
            btnMemoryRecall.UseVisualStyleBackColor = true;
            // 
            // btnMemorySave
            // 
            btnMemorySave.Location = new Point(2, 218);
            btnMemorySave.Name = "btnMemorySave";
            btnMemorySave.Size = new Size(84, 29);
            btnMemorySave.TabIndex = 6;
            btnMemorySave.Text = "MS";
            btnMemorySave.UseVisualStyleBackColor = true;
            // 
            // btnMemoryPlus
            // 
            btnMemoryPlus.Location = new Point(2, 253);
            btnMemoryPlus.Name = "btnMemoryPlus";
            btnMemoryPlus.Size = new Size(84, 29);
            btnMemoryPlus.TabIndex = 7;
            btnMemoryPlus.Text = "+M";
            btnMemoryPlus.UseVisualStyleBackColor = true;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(243, 148);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(60, 29);
            btnDivide.TabIndex = 8;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            // 
            // btnMultiple
            // 
            btnMultiple.Location = new Point(243, 183);
            btnMultiple.Name = "btnMultiple";
            btnMultiple.Size = new Size(60, 29);
            btnMultiple.TabIndex = 9;
            btnMultiple.Text = "*";
            btnMultiple.UseVisualStyleBackColor = true;
            // 
            // btnSubtrac
            // 
            btnSubtrac.Location = new Point(243, 218);
            btnSubtrac.Name = "btnSubtrac";
            btnSubtrac.Size = new Size(60, 29);
            btnSubtrac.TabIndex = 10;
            btnSubtrac.Text = "-";
            btnSubtrac.UseVisualStyleBackColor = true;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(243, 253);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(60, 29);
            btnPlus.TabIndex = 11;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            // 
            // btnSqrt
            // 
            btnSqrt.ForeColor = Color.Blue;
            btnSqrt.Location = new Point(309, 148);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(54, 29);
            btnSqrt.TabIndex = 12;
            btnSqrt.Text = "Sqrt";
            btnSqrt.UseVisualStyleBackColor = true;
            // 
            // btnPercent
            // 
            btnPercent.ForeColor = Color.Blue;
            btnPercent.Location = new Point(309, 183);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(54, 29);
            btnPercent.TabIndex = 13;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = true;
            // 
            // btnOneOverX
            // 
            btnOneOverX.ForeColor = Color.Blue;
            btnOneOverX.Location = new Point(309, 218);
            btnOneOverX.Name = "btnOneOverX";
            btnOneOverX.Size = new Size(54, 29);
            btnOneOverX.TabIndex = 14;
            btnOneOverX.Text = "1/x";
            btnOneOverX.UseVisualStyleBackColor = true;
            // 
            // btnEquals
            // 
            btnEquals.Location = new Point(309, 253);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(54, 29);
            btnEquals.TabIndex = 15;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            // 
            // btnPlusMinis
            // 
            btnPlusMinis.ForeColor = Color.Blue;
            btnPlusMinis.Location = new Point(138, 253);
            btnPlusMinis.Name = "btnPlusMinis";
            btnPlusMinis.Size = new Size(54, 29);
            btnPlusMinis.TabIndex = 16;
            btnPlusMinis.Text = "+/-";
            btnPlusMinis.UseVisualStyleBackColor = true;
            // 
            // btnPeriod
            // 
            btnPeriod.ForeColor = Color.Blue;
            btnPeriod.Location = new Point(198, 253);
            btnPeriod.Name = "btnPeriod";
            btnPeriod.Size = new Size(43, 29);
            btnPeriod.TabIndex = 17;
            btnPeriod.Text = ".";
            btnPeriod.UseVisualStyleBackColor = true;
            // 
            // Btn0
            // 
            Btn0.ForeColor = Color.Blue;
            Btn0.Location = new Point(92, 253);
            Btn0.Name = "Btn0";
            Btn0.Size = new Size(43, 29);
            Btn0.TabIndex = 18;
            Btn0.Text = "0";
            Btn0.UseVisualStyleBackColor = true;
            Btn0.Click += Btn0_Click;
            // 
            // Btn1
            // 
            Btn1.ForeColor = Color.Blue;
            Btn1.Location = new Point(93, 218);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(43, 29);
            Btn1.TabIndex = 19;
            Btn1.Text = "1";
            Btn1.UseVisualStyleBackColor = true;
            Btn1.Click += Btn1_Click;
            // 
            // Btn2
            // 
            Btn2.ForeColor = Color.Blue;
            Btn2.Location = new Point(142, 218);
            Btn2.Name = "Btn2";
            Btn2.Size = new Size(50, 29);
            Btn2.TabIndex = 20;
            Btn2.Text = "2";
            Btn2.UseVisualStyleBackColor = true;
            Btn2.Click += Btn2_Click;
            // 
            // Btn3
            // 
            Btn3.ForeColor = Color.Blue;
            Btn3.Location = new Point(198, 218);
            Btn3.Name = "Btn3";
            Btn3.Size = new Size(43, 29);
            Btn3.TabIndex = 21;
            Btn3.Text = "3";
            Btn3.UseVisualStyleBackColor = true;
            Btn3.Click += Btn3_Click;
            // 
            // Btn4
            // 
            Btn4.ForeColor = Color.Blue;
            Btn4.Location = new Point(92, 183);
            Btn4.Name = "Btn4";
            Btn4.Size = new Size(43, 29);
            Btn4.TabIndex = 22;
            Btn4.Text = "4";
            Btn4.UseVisualStyleBackColor = true;
            Btn4.Click += Btn4_Click;
            // 
            // Btn5
            // 
            Btn5.ForeColor = Color.Blue;
            Btn5.Location = new Point(142, 183);
            Btn5.Name = "Btn5";
            Btn5.Size = new Size(50, 29);
            Btn5.TabIndex = 23;
            Btn5.Text = "5";
            Btn5.UseVisualStyleBackColor = true;
            Btn5.Click += Btn5_Click;
            // 
            // Btn6
            // 
            Btn6.ForeColor = Color.Blue;
            Btn6.Location = new Point(198, 183);
            Btn6.Name = "Btn6";
            Btn6.Size = new Size(43, 29);
            Btn6.TabIndex = 24;
            Btn6.Text = "6";
            Btn6.UseVisualStyleBackColor = true;
            Btn6.Click += Btn6_Click;
            // 
            // Btn7
            // 
            Btn7.ForeColor = Color.Blue;
            Btn7.Location = new Point(93, 148);
            Btn7.Name = "Btn7";
            Btn7.Size = new Size(43, 29);
            Btn7.TabIndex = 25;
            Btn7.Text = "7";
            Btn7.UseVisualStyleBackColor = true;
            Btn7.Click += Btn7_Click;
            // 
            // Btn8
            // 
            Btn8.ForeColor = Color.Blue;
            Btn8.Location = new Point(142, 148);
            Btn8.Name = "Btn8";
            Btn8.Size = new Size(50, 29);
            Btn8.TabIndex = 26;
            Btn8.Text = "8";
            Btn8.UseVisualStyleBackColor = true;
            Btn8.Click += Btn8_Click;
            // 
            // Btn9
            // 
            Btn9.ForeColor = Color.Blue;
            Btn9.Location = new Point(198, 148);
            Btn9.Name = "Btn9";
            Btn9.Size = new Size(43, 29);
            Btn9.TabIndex = 27;
            Btn9.Text = "9";
            Btn9.UseVisualStyleBackColor = true;
            Btn9.Click += Btn9_Click;
            // 
            // frmCalculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 304);
            Controls.Add(Btn9);
            Controls.Add(Btn8);
            Controls.Add(Btn7);
            Controls.Add(Btn6);
            Controls.Add(Btn5);
            Controls.Add(Btn4);
            Controls.Add(Btn3);
            Controls.Add(Btn2);
            Controls.Add(Btn1);
            Controls.Add(Btn0);
            Controls.Add(btnPeriod);
            Controls.Add(btnPlusMinis);
            Controls.Add(btnEquals);
            Controls.Add(btnOneOverX);
            Controls.Add(btnPercent);
            Controls.Add(btnSqrt);
            Controls.Add(btnPlus);
            Controls.Add(btnSubtrac);
            Controls.Add(btnMultiple);
            Controls.Add(btnDivide);
            Controls.Add(btnMemoryPlus);
            Controls.Add(btnMemorySave);
            Controls.Add(btnMemoryRecall);
            Controls.Add(btnMemoryClear);
            Controls.Add(btnCLear);
            Controls.Add(btnCE);
            Controls.Add(btnBackspace);
            Controls.Add(txtValue);
            ForeColor = Color.Red;
            Name = "frmCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            Load += frmCalculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValue;
        private Button btnBackspace;
        private Button btnCE;
        private Button btnCLear;
        private Button btnMemoryClear;
        private Button btnMemoryRecall;
        private Button btnMemorySave;
        private Button btnMemoryPlus;
        private Button btnDivide;
        private Button btnMultiple;
        private Button btnSubtrac;
        private Button btnPlus;
        private Button btnSqrt;
        private Button btnPercent;
        private Button btnOneOverX;
        private Button btnEquals;
        private Button btnPlusMinis;
        private Button btnPeriod;
        private Button Btn0;
        private Button Btn1;
        private Button Btn2;
        private Button Btn3;
        private Button Btn4;
        private Button Btn5;
        private Button Btn6;
        private Button Btn7;
        private Button Btn8;
        private Button Btn9;
    }
}
