namespace CeaserCiper
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
            this.EncrypButton = new System.Windows.Forms.Button();
            this.rot2RadioButton = new System.Windows.Forms.RadioButton();
            this.ceaserCipherRadioButton = new System.Windows.Forms.RadioButton();
            this.ceaserTextBox = new System.Windows.Forms.TextBox();
            this.successLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.cipherLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.headChipherCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EncrypButton
            // 
            this.EncrypButton.Location = new System.Drawing.Point(94, 266);
            this.EncrypButton.Name = "EncrypButton";
            this.EncrypButton.Size = new System.Drawing.Size(75, 23);
            this.EncrypButton.TabIndex = 0;
            this.EncrypButton.Text = "ENCRYPT";
            this.EncrypButton.UseVisualStyleBackColor = true;
            this.EncrypButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // rot2RadioButton
            // 
            this.rot2RadioButton.AutoSize = true;
            this.rot2RadioButton.Location = new System.Drawing.Point(335, 76);
            this.rot2RadioButton.Name = "rot2RadioButton";
            this.rot2RadioButton.Size = new System.Drawing.Size(54, 17);
            this.rot2RadioButton.TabIndex = 1;
            this.rot2RadioButton.TabStop = true;
            this.rot2RadioButton.Text = "ROT2";
            this.rot2RadioButton.UseVisualStyleBackColor = true;
            this.rot2RadioButton.CheckedChanged += new System.EventHandler(this.rot2RadioButton_CheckedChanged);
            // 
            // ceaserCipherRadioButton
            // 
            this.ceaserCipherRadioButton.AutoSize = true;
            this.ceaserCipherRadioButton.Location = new System.Drawing.Point(335, 117);
            this.ceaserCipherRadioButton.Name = "ceaserCipherRadioButton";
            this.ceaserCipherRadioButton.Size = new System.Drawing.Size(111, 17);
            this.ceaserCipherRadioButton.TabIndex = 2;
            this.ceaserCipherRadioButton.TabStop = true;
            this.ceaserCipherRadioButton.Text = "CEASER CIPHER";
            this.ceaserCipherRadioButton.UseVisualStyleBackColor = true;
            this.ceaserCipherRadioButton.CheckedChanged += new System.EventHandler(this.ceaserCipherRadioButton_CheckedChanged);
            // 
            // ceaserTextBox
            // 
            this.ceaserTextBox.Location = new System.Drawing.Point(67, 213);
            this.ceaserTextBox.Name = "ceaserTextBox";
            this.ceaserTextBox.Size = new System.Drawing.Size(137, 20);
            this.ceaserTextBox.TabIndex = 3;
            this.ceaserTextBox.TextChanged += new System.EventHandler(this.ceaserTextBox_TextChanged);
            // 
            // successLabel
            // 
            this.successLabel.AutoSize = true;
            this.successLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.successLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.successLabel.Location = new System.Drawing.Point(330, 176);
            this.successLabel.Name = "successLabel";
            this.successLabel.Size = new System.Drawing.Size(76, 25);
            this.successLabel.TabIndex = 4;
            this.successLabel.Text = "label1";
            this.successLabel.Click += new System.EventHandler(this.successLabel_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(67, 114);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(137, 20);
            this.passwordTextBox.TabIndex = 5;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // cipherLabel
            // 
            this.cipherLabel.AutoSize = true;
            this.cipherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cipherLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cipherLabel.Location = new System.Drawing.Point(331, 213);
            this.cipherLabel.Name = "cipherLabel";
            this.cipherLabel.Size = new System.Drawing.Size(0, 24);
            this.cipherLabel.TabIndex = 6;
            this.cipherLabel.Click += new System.EventHandler(this.cipherLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "PASSWORD";
            // 
            // headChipherCode
            // 
            this.headChipherCode.AutoSize = true;
            this.headChipherCode.Location = new System.Drawing.Point(98, 176);
            this.headChipherCode.Name = "headChipherCode";
            this.headChipherCode.Size = new System.Drawing.Size(80, 13);
            this.headChipherCode.TabIndex = 8;
            this.headChipherCode.Text = "CIPHER CODE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 338);
            this.Controls.Add(this.headChipherCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cipherLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.successLabel);
            this.Controls.Add(this.ceaserTextBox);
            this.Controls.Add(this.ceaserCipherRadioButton);
            this.Controls.Add(this.rot2RadioButton);
            this.Controls.Add(this.EncrypButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EncrypButton;
        private System.Windows.Forms.RadioButton rot2RadioButton;
        private System.Windows.Forms.RadioButton ceaserCipherRadioButton;
        private System.Windows.Forms.TextBox ceaserTextBox;
        private System.Windows.Forms.Label successLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label cipherLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label headChipherCode;
    }
}

