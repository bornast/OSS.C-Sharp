namespace Labs
{
    partial class SummayForm
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
            this.personsFromSplitLabel = new System.Windows.Forms.Label();
            this.personsFromZagrebLabel = new System.Windows.Forms.Label();
            this.personsFromRijekaLabel = new System.Windows.Forms.Label();
            this.splitCounter = new System.Windows.Forms.Label();
            this.zagrebCounter = new System.Windows.Forms.Label();
            this.rijekaCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // personsFromSplitLabel
            // 
            this.personsFromSplitLabel.AutoSize = true;
            this.personsFromSplitLabel.Location = new System.Drawing.Point(77, 77);
            this.personsFromSplitLabel.Name = "personsFromSplitLabel";
            this.personsFromSplitLabel.Size = new System.Drawing.Size(123, 17);
            this.personsFromSplitLabel.TabIndex = 0;
            this.personsFromSplitLabel.Text = "Persons from Split";
            // 
            // personsFromZagrebLabel
            // 
            this.personsFromZagrebLabel.AutoSize = true;
            this.personsFromZagrebLabel.Location = new System.Drawing.Point(80, 156);
            this.personsFromZagrebLabel.Name = "personsFromZagrebLabel";
            this.personsFromZagrebLabel.Size = new System.Drawing.Size(142, 17);
            this.personsFromZagrebLabel.TabIndex = 1;
            this.personsFromZagrebLabel.Text = "Persons from Zagreb";
            // 
            // personsFromRijekaLabel
            // 
            this.personsFromRijekaLabel.AutoSize = true;
            this.personsFromRijekaLabel.Location = new System.Drawing.Point(80, 234);
            this.personsFromRijekaLabel.Name = "personsFromRijekaLabel";
            this.personsFromRijekaLabel.Size = new System.Drawing.Size(135, 17);
            this.personsFromRijekaLabel.TabIndex = 2;
            this.personsFromRijekaLabel.Text = "Persons from Rijeka";
            // 
            // splitCounter
            // 
            this.splitCounter.AutoSize = true;
            this.splitCounter.Location = new System.Drawing.Point(280, 77);
            this.splitCounter.Name = "splitCounter";
            this.splitCounter.Size = new System.Drawing.Size(0, 17);
            this.splitCounter.TabIndex = 3;
            // 
            // zagrebCounter
            // 
            this.zagrebCounter.AutoSize = true;
            this.zagrebCounter.Location = new System.Drawing.Point(283, 155);
            this.zagrebCounter.Name = "zagrebCounter";
            this.zagrebCounter.Size = new System.Drawing.Size(0, 17);
            this.zagrebCounter.TabIndex = 4;
            // 
            // rijekaCounter
            // 
            this.rijekaCounter.AutoSize = true;
            this.rijekaCounter.Location = new System.Drawing.Point(283, 233);
            this.rijekaCounter.Name = "rijekaCounter";
            this.rijekaCounter.Size = new System.Drawing.Size(0, 17);
            this.rijekaCounter.TabIndex = 5;
            // 
            // SummayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rijekaCounter);
            this.Controls.Add(this.zagrebCounter);
            this.Controls.Add(this.splitCounter);
            this.Controls.Add(this.personsFromRijekaLabel);
            this.Controls.Add(this.personsFromZagrebLabel);
            this.Controls.Add(this.personsFromSplitLabel);
            this.Name = "SummayForm";
            this.Text = "SummayForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label personsFromSplitLabel;
        private System.Windows.Forms.Label personsFromZagrebLabel;
        private System.Windows.Forms.Label personsFromRijekaLabel;
        private System.Windows.Forms.Label splitCounter;
        private System.Windows.Forms.Label zagrebCounter;
        private System.Windows.Forms.Label rijekaCounter;
    }
}