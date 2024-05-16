namespace Week6_OOP_csharp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxTimeZones = new System.Windows.Forms.ComboBox();
            this.checkedListBoxTimeZones = new System.Windows.Forms.CheckedListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelDigitalClock = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxTimeZones
            // 
            this.comboBoxTimeZones.FormattingEnabled = true;
            this.comboBoxTimeZones.Location = new System.Drawing.Point(262, 125);
            this.comboBoxTimeZones.Name = "comboBoxTimeZones";
            this.comboBoxTimeZones.Size = new System.Drawing.Size(142, 24);
            this.comboBoxTimeZones.TabIndex = 0;
            this.comboBoxTimeZones.Text = "Select Time Zone";
            this.comboBoxTimeZones.SelectedIndexChanged += new System.EventHandler(this.comboBoxTimeZones_SelectedIndexChanged);
            // 
            // checkedListBoxTimeZones
            // 
            this.checkedListBoxTimeZones.FormattingEnabled = true;
            this.checkedListBoxTimeZones.Location = new System.Drawing.Point(498, 125);
            this.checkedListBoxTimeZones.Name = "checkedListBoxTimeZones";
            this.checkedListBoxTimeZones.Size = new System.Drawing.Size(222, 89);
            this.checkedListBoxTimeZones.TabIndex = 1;
            this.checkedListBoxTimeZones.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxTimeZones_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(288, 314);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(478, 314);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(633, 314);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(288, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // labelDigitalClock
            // 
            this.labelDigitalClock.AutoSize = true;
            this.labelDigitalClock.Location = new System.Drawing.Point(97, 321);
            this.labelDigitalClock.Name = "labelDigitalClock";
            this.labelDigitalClock.Size = new System.Drawing.Size(44, 16);
            this.labelDigitalClock.TabIndex = 6;
            this.labelDigitalClock.Text = "label1";
            this.labelDigitalClock.Click += new System.EventHandler(this.labelDigitalClock_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDigitalClock);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.checkedListBoxTimeZones);
            this.Controls.Add(this.comboBoxTimeZones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.ComboBox comboBoxTimeZones;
        private System.Windows.Forms.CheckedListBox checkedListBoxTimeZones;
        private System.Windows.Forms.DateTimePicker dateTimePickerTime;
        private System.Windows.Forms.TextBox textBoxTimeZone;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelDigitalClock;
    }
}

