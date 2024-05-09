namespace HangMan
{
    partial class Settings
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonEasy = new System.Windows.Forms.RadioButton();
            this.radioButtonMid = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonHard = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonTime = new System.Windows.Forms.RadioButton();
            this.radioButtonNoTime = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonClueNo = new System.Windows.Forms.RadioButton();
            this.radioButtonClue = new System.Windows.Forms.RadioButton();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "SCIENCE",
            "TECHNOLOGY",
            "LITERATURE",
            "ANIMALS",
            "PLANTS"});
            this.listBox1.Location = new System.Drawing.Point(74, 104);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(74, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "SELECT CATEGORY ";
            // 
            // radioButtonEasy
            // 
            this.radioButtonEasy.AutoSize = true;
            this.radioButtonEasy.Location = new System.Drawing.Point(6, 21);
            this.radioButtonEasy.Name = "radioButtonEasy";
            this.radioButtonEasy.Size = new System.Drawing.Size(160, 20);
            this.radioButtonEasy.TabIndex = 2;
            this.radioButtonEasy.TabStop = true;
            this.radioButtonEasy.Text = "Easy    3-6 letter words";
            this.radioButtonEasy.UseVisualStyleBackColor = true;
            // 
            // radioButtonMid
            // 
            this.radioButtonMid.AutoSize = true;
            this.radioButtonMid.Location = new System.Drawing.Point(6, 48);
            this.radioButtonMid.Name = "radioButtonMid";
            this.radioButtonMid.Size = new System.Drawing.Size(164, 20);
            this.radioButtonMid.TabIndex = 3;
            this.radioButtonMid.TabStop = true;
            this.radioButtonMid.Text = "Mid      7-10 letter words";
            this.radioButtonMid.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.radioButtonEasy);
            this.groupBox1.Controls.Add(this.radioButtonHard);
            this.groupBox1.Controls.Add(this.radioButtonMid);
            this.groupBox1.Location = new System.Drawing.Point(74, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Level";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButtonHard
            // 
            this.radioButtonHard.AutoSize = true;
            this.radioButtonHard.Location = new System.Drawing.Point(6, 74);
            this.radioButtonHard.Name = "radioButtonHard";
            this.radioButtonHard.Size = new System.Drawing.Size(165, 20);
            this.radioButtonHard.TabIndex = 3;
            this.radioButtonHard.TabStop = true;
            this.radioButtonHard.Text = "Hard    11 or more letter";
            this.radioButtonHard.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.radioButtonTime);
            this.groupBox2.Controls.Add(this.radioButtonNoTime);
            this.groupBox2.Location = new System.Drawing.Point(560, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 84);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Time";
            // 
            // radioButtonTime
            // 
            this.radioButtonTime.AutoSize = true;
            this.radioButtonTime.Location = new System.Drawing.Point(6, 47);
            this.radioButtonTime.Name = "radioButtonTime";
            this.radioButtonTime.Size = new System.Drawing.Size(92, 20);
            this.radioButtonTime.TabIndex = 6;
            this.radioButtonTime.TabStop = true;
            this.radioButtonTime.Text = "30 Second";
            this.radioButtonTime.UseVisualStyleBackColor = true;
            // 
            // radioButtonNoTime
            // 
            this.radioButtonNoTime.AutoSize = true;
            this.radioButtonNoTime.Location = new System.Drawing.Point(6, 21);
            this.radioButtonNoTime.Name = "radioButtonNoTime";
            this.radioButtonNoTime.Size = new System.Drawing.Size(84, 20);
            this.radioButtonNoTime.TabIndex = 6;
            this.radioButtonNoTime.TabStop = true;
            this.radioButtonNoTime.Text = "No timing";
            this.radioButtonNoTime.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.radioButtonClueNo);
            this.groupBox3.Controls.Add(this.radioButtonClue);
            this.groupBox3.Location = new System.Drawing.Point(560, 271);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Show Clue";
            // 
            // radioButtonClueNo
            // 
            this.radioButtonClueNo.AutoSize = true;
            this.radioButtonClueNo.Location = new System.Drawing.Point(6, 51);
            this.radioButtonClueNo.Name = "radioButtonClueNo";
            this.radioButtonClueNo.Size = new System.Drawing.Size(46, 20);
            this.radioButtonClueNo.TabIndex = 7;
            this.radioButtonClueNo.TabStop = true;
            this.radioButtonClueNo.Text = "No";
            this.radioButtonClueNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonClue
            // 
            this.radioButtonClue.AutoSize = true;
            this.radioButtonClue.Location = new System.Drawing.Point(6, 25);
            this.radioButtonClue.Name = "radioButtonClue";
            this.radioButtonClue.Size = new System.Drawing.Size(52, 20);
            this.radioButtonClue.TabIndex = 7;
            this.radioButtonClue.TabStop = true;
            this.radioButtonClue.Text = "Yes";
            this.radioButtonClue.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Lime;
            this.buttonSave.Location = new System.Drawing.Point(560, 389);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonEasy;
        private System.Windows.Forms.RadioButton radioButtonMid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonHard;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonTime;
        private System.Windows.Forms.RadioButton radioButtonNoTime;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonClueNo;
        private System.Windows.Forms.RadioButton radioButtonClue;
        private System.Windows.Forms.Button buttonSave;
    }
}