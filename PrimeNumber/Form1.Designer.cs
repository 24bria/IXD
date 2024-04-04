namespace PrimeNumber
{
    partial class PrimeNumberForm
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
            this.CheckButton = new System.Windows.Forms.Button();
            this.PrimeNumberTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(303, 173);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(151, 62);
            this.CheckButton.TabIndex = 0;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // PrimeNumberTextBox
            // 
            this.PrimeNumberTextBox.Location = new System.Drawing.Point(332, 135);
            this.PrimeNumberTextBox.Name = "PrimeNumberTextBox";
            this.PrimeNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.PrimeNumberTextBox.TabIndex = 1;
            this.PrimeNumberTextBox.TextChanged += new System.EventHandler(this.PrimeNumberTextbox_TextChanged);
            // 
            // PrimeNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PrimeNumberTextBox);
            this.Controls.Add(this.CheckButton);
            this.Name = "PrimeNumberForm";
            this.Text = "PrimeNumber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.TextBox PrimeNumberTextBox;
    }
}

