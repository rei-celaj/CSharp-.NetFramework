namespace Assignment4
{
    partial class frmEvaluation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTest1 = new System.Windows.Forms.Label();
            this.txtTest1 = new System.Windows.Forms.TextBox();
            this.txtTest2 = new System.Windows.Forms.TextBox();
            this.lblTest2 = new System.Windows.Forms.Label();
            this.txtTest3 = new System.Windows.Forms.TextBox();
            this.lblTest3 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.lblHours = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.lblYears = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTest1
            // 
            this.lblTest1.AutoSize = true;
            this.lblTest1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTest1.Location = new System.Drawing.Point(37, 80);
            this.lblTest1.Name = "lblTest1";
            this.lblTest1.Size = new System.Drawing.Size(143, 20);
            this.lblTest1.TabIndex = 0;
            this.lblTest1.Text = "Test Score Part A";
            // 
            // txtTest1
            // 
            this.txtTest1.Location = new System.Drawing.Point(204, 80);
            this.txtTest1.Name = "txtTest1";
            this.txtTest1.Size = new System.Drawing.Size(100, 22);
            this.txtTest1.TabIndex = 1;
            // 
            // txtTest2
            // 
            this.txtTest2.Location = new System.Drawing.Point(204, 128);
            this.txtTest2.Name = "txtTest2";
            this.txtTest2.Size = new System.Drawing.Size(100, 22);
            this.txtTest2.TabIndex = 3;
            this.txtTest2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblTest2
            // 
            this.lblTest2.AutoSize = true;
            this.lblTest2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTest2.Location = new System.Drawing.Point(37, 128);
            this.lblTest2.Name = "lblTest2";
            this.lblTest2.Size = new System.Drawing.Size(144, 20);
            this.lblTest2.TabIndex = 2;
            this.lblTest2.Text = "Test Score Part B";
            this.lblTest2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTest3
            // 
            this.txtTest3.Location = new System.Drawing.Point(204, 175);
            this.txtTest3.Name = "txtTest3";
            this.txtTest3.Size = new System.Drawing.Size(100, 22);
            this.txtTest3.TabIndex = 5;
            this.txtTest3.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lblTest3
            // 
            this.lblTest3.AutoSize = true;
            this.lblTest3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTest3.Location = new System.Drawing.Point(37, 175);
            this.lblTest3.Name = "lblTest3";
            this.lblTest3.Size = new System.Drawing.Size(144, 20);
            this.lblTest3.TabIndex = 4;
            this.lblTest3.Text = "Test Score Part C";
            this.lblTest3.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(581, 155);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(100, 22);
            this.txtType.TabIndex = 7;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblType.Location = new System.Drawing.Point(360, 155);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(186, 20);
            this.lblType.TabIndex = 6;
            this.lblType.Text = "Part or Full Time? (P/F)";
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(617, 203);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(100, 22);
            this.txtHours.TabIndex = 9;
            this.txtHours.Text = "0";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHours.Location = new System.Drawing.Point(360, 201);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(219, 20);
            this.lblHours.TabIndex = 8;
            this.lblHours.Text = "Hours worked? (If part time)";
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCalc.Location = new System.Drawing.Point(60, 265);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(120, 31);
            this.btnCalc.TabIndex = 10;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClear.Location = new System.Drawing.Point(203, 265);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 31);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExit.Location = new System.Drawing.Point(127, 302);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 31);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(620, 376);
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.Size = new System.Drawing.Size(100, 22);
            this.txtScore.TabIndex = 14;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblScore.Location = new System.Drawing.Point(486, 376);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(91, 20);
            this.lblScore.TabIndex = 13;
            this.lblScore.Text = "Test Score";
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(613, 319);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.ReadOnly = true;
            this.txtGrade.Size = new System.Drawing.Size(100, 22);
            this.txtGrade.TabIndex = 16;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGrade.Location = new System.Drawing.Point(486, 319);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(93, 20);
            this.lblGrade.TabIndex = 15;
            this.lblGrade.Text = "Test Grade";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(621, 263);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.ReadOnly = true;
            this.txtSalary.Size = new System.Drawing.Size(100, 22);
            this.txtSalary.TabIndex = 18;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSalary.Location = new System.Drawing.Point(540, 265);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(56, 20);
            this.lblSalary.TabIndex = 17;
            this.lblSalary.Text = "Salary";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblName.Location = new System.Drawing.Point(360, 67);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 20);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(446, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 20;
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(527, 111);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(100, 22);
            this.txtYears.TabIndex = 22;
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblYears.Location = new System.Drawing.Point(360, 111);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(141, 20);
            this.lblYears.TabIndex = 21;
            this.lblYears.Text = "# of years worked";
            // 
            // frmEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtYears);
            this.Controls.Add(this.lblYears);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtTest3);
            this.Controls.Add(this.lblTest3);
            this.Controls.Add(this.txtTest2);
            this.Controls.Add(this.lblTest2);
            this.Controls.Add(this.txtTest1);
            this.Controls.Add(this.lblTest1);
            this.Name = "frmEvaluation";
            this.Text = "Employee Evaluation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTest1;
        private System.Windows.Forms.TextBox txtTest1;
        private System.Windows.Forms.TextBox txtTest2;
        private System.Windows.Forms.Label lblTest2;
        private System.Windows.Forms.TextBox txtTest3;
        private System.Windows.Forms.Label lblTest3;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.Label lblYears;
    }
}

