namespace Assignment6
{
    partial class frmSport
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
            this.lblSport = new System.Windows.Forms.Label();
            this.txtSport = new System.Windows.Forms.TextBox();
            this.lblSportEntry = new System.Windows.Forms.Label();
            this.txtSportEntry = new System.Windows.Forms.TextBox();
            this.txtParticipants = new System.Windows.Forms.TextBox();
            this.lblParticipants = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnNewSport = new System.Windows.Forms.Button();
            this.btnHighestSport = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSpecific = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSport
            // 
            this.lblSport.AutoSize = true;
            this.lblSport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSport.Location = new System.Drawing.Point(93, 30);
            this.lblSport.Name = "lblSport";
            this.lblSport.Size = new System.Drawing.Size(184, 20);
            this.lblSport.TabIndex = 0;
            this.lblSport.Text = "Sports and Participants";
            this.lblSport.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSport
            // 
            this.txtSport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtSport.ForeColor = System.Drawing.Color.White;
            this.txtSport.Location = new System.Drawing.Point(97, 53);
            this.txtSport.Multiline = true;
            this.txtSport.Name = "txtSport";
            this.txtSport.ReadOnly = true;
            this.txtSport.Size = new System.Drawing.Size(170, 181);
            this.txtSport.TabIndex = 1;
            this.txtSport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSportEntry
            // 
            this.lblSportEntry.AutoSize = true;
            this.lblSportEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSportEntry.Location = new System.Drawing.Point(368, 89);
            this.lblSportEntry.Name = "lblSportEntry";
            this.lblSportEntry.Size = new System.Drawing.Size(54, 20);
            this.lblSportEntry.TabIndex = 2;
            this.lblSportEntry.Text = "Sport:";
            // 
            // txtSportEntry
            // 
            this.txtSportEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtSportEntry.Location = new System.Drawing.Point(450, 89);
            this.txtSportEntry.Name = "txtSportEntry";
            this.txtSportEntry.Size = new System.Drawing.Size(100, 24);
            this.txtSportEntry.TabIndex = 3;
            // 
            // txtParticipants
            // 
            this.txtParticipants.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtParticipants.Location = new System.Drawing.Point(450, 158);
            this.txtParticipants.Name = "txtParticipants";
            this.txtParticipants.Size = new System.Drawing.Size(100, 24);
            this.txtParticipants.TabIndex = 5;
            // 
            // lblParticipants
            // 
            this.lblParticipants.AutoSize = true;
            this.lblParticipants.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblParticipants.Location = new System.Drawing.Point(286, 158);
            this.lblParticipants.Name = "lblParticipants";
            this.lblParticipants.Size = new System.Drawing.Size(136, 20);
            this.lblParticipants.TabIndex = 4;
            this.lblParticipants.Text = "# of Participants:";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDisplay.Location = new System.Drawing.Point(24, 293);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(92, 34);
            this.btnDisplay.TabIndex = 6;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnNewSport
            // 
            this.btnNewSport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNewSport.Location = new System.Drawing.Point(530, 283);
            this.btnNewSport.Name = "btnNewSport";
            this.btnNewSport.Size = new System.Drawing.Size(111, 55);
            this.btnNewSport.TabIndex = 7;
            this.btnNewSport.Text = "Enter new Sport";
            this.btnNewSport.UseVisualStyleBackColor = false;
            this.btnNewSport.Click += new System.EventHandler(this.btnNewSport_Click);
            // 
            // btnHighestSport
            // 
            this.btnHighestSport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnHighestSport.Location = new System.Drawing.Point(24, 357);
            this.btnHighestSport.Name = "btnHighestSport";
            this.btnHighestSport.Size = new System.Drawing.Size(92, 73);
            this.btnHighestSport.TabIndex = 8;
            this.btnHighestSport.Text = "Find Highest Sport";
            this.btnHighestSport.UseVisualStyleBackColor = true;
            this.btnHighestSport.Click += new System.EventHandler(this.btnHighestSport_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDelete.Location = new System.Drawing.Point(530, 367);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 52);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete a Sport";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClear.Location = new System.Drawing.Point(372, 293);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 34);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExit.Location = new System.Drawing.Point(372, 374);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 34);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSpecific
            // 
            this.btnSpecific.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSpecific.Location = new System.Drawing.Point(179, 314);
            this.btnSpecific.Name = "btnSpecific";
            this.btnSpecific.Size = new System.Drawing.Size(130, 74);
            this.btnSpecific.TabIndex = 12;
            this.btnSpecific.Text = "Display specific element";
            this.btnSpecific.UseVisualStyleBackColor = true;
            this.btnSpecific.Click += new System.EventHandler(this.btnSpecific_Click);
            // 
            // frmSport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSpecific);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnHighestSport);
            this.Controls.Add(this.btnNewSport);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.txtParticipants);
            this.Controls.Add(this.lblParticipants);
            this.Controls.Add(this.txtSportEntry);
            this.Controls.Add(this.lblSportEntry);
            this.Controls.Add(this.txtSport);
            this.Controls.Add(this.lblSport);
            this.Name = "frmSport";
            this.Text = "Sport Instituition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSport;
        private System.Windows.Forms.TextBox txtSport;
        private System.Windows.Forms.Label lblSportEntry;
        private System.Windows.Forms.TextBox txtSportEntry;
        private System.Windows.Forms.TextBox txtParticipants;
        private System.Windows.Forms.Label lblParticipants;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnNewSport;
        private System.Windows.Forms.Button btnHighestSport;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSpecific;
    }
}

