namespace SimonSays
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
            this.greenButton = new System.Windows.Forms.Button();
            this.redButton = new System.Windows.Forms.Button();
            this.yellowButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.Green;
            this.greenButton.Location = new System.Drawing.Point(12, 12);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(300, 279);
            this.greenButton.TabIndex = 0;
            this.greenButton.Text = "GREEN";
            this.greenButton.UseVisualStyleBackColor = false;
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.Red;
            this.redButton.Location = new System.Drawing.Point(318, 12);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(300, 279);
            this.redButton.TabIndex = 1;
            this.redButton.Text = "RED";
            this.redButton.UseVisualStyleBackColor = false;
            // 
            // yellowButton
            // 
            this.yellowButton.BackColor = System.Drawing.Color.Yellow;
            this.yellowButton.Location = new System.Drawing.Point(12, 297);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(300, 279);
            this.yellowButton.TabIndex = 2;
            this.yellowButton.Text = "YELLOW";
            this.yellowButton.UseVisualStyleBackColor = false;
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.Blue;
            this.blueButton.Location = new System.Drawing.Point(318, 297);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(300, 279);
            this.blueButton.TabIndex = 3;
            this.blueButton.Text = "BLUE";
            this.blueButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 589);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.greenButton);
            this.Name = "Form1";
            this.Text = "Simon Says";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Button blueButton;
    }
}

