namespace HangMan
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
            this.Startbutton = new System.Windows.Forms.Button();
            this.Settingsbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Startbutton
            // 
            this.Startbutton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Startbutton.Location = new System.Drawing.Point(354, 378);
            this.Startbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(134, 52);
            this.Startbutton.TabIndex = 0;
            this.Startbutton.Text = "START";
            this.Startbutton.UseVisualStyleBackColor = false;
            this.Startbutton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // Settingsbutton
            // 
            this.Settingsbutton.BackColor = System.Drawing.Color.Gold;
            this.Settingsbutton.Location = new System.Drawing.Point(555, 378);
            this.Settingsbutton.Name = "Settingsbutton";
            this.Settingsbutton.Size = new System.Drawing.Size(123, 52);
            this.Settingsbutton.TabIndex = 1;
            this.Settingsbutton.Text = "SETTINGS";
            this.Settingsbutton.UseVisualStyleBackColor = false;
            this.Settingsbutton.Click += new System.EventHandler(this.Settingsbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(352, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 69);
            this.label1.TabIndex = 2;
            this.label1.Text = "HANGMAN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Settingsbutton);
            this.Controls.Add(this.Startbutton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Startbutton;
        private System.Windows.Forms.Button Settingsbutton;
        private System.Windows.Forms.Label label1;
    }
}

