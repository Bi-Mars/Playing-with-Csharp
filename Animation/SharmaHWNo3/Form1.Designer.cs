namespace SharmaHWNo3
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.Faster = new System.Windows.Forms.Button();
            this.Slower = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, -1);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(365, 437);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // Faster
            // 
            this.Faster.Location = new System.Drawing.Point(49, 461);
            this.Faster.Name = "Faster";
            this.Faster.Size = new System.Drawing.Size(101, 36);
            this.Faster.TabIndex = 1;
            this.Faster.Text = "Faster";
            this.Faster.UseVisualStyleBackColor = true;
            this.Faster.Click += new System.EventHandler(this.Faster_Click);
            // 
            // Slower
            // 
            this.Slower.Location = new System.Drawing.Point(215, 461);
            this.Slower.Name = "Slower";
            this.Slower.Size = new System.Drawing.Size(101, 36);
            this.Slower.TabIndex = 2;
            this.Slower.Text = "Slower";
            this.Slower.UseVisualStyleBackColor = true;
            this.Slower.Click += new System.EventHandler(this.Slower_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(400, 116);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(101, 36);
            this.Start.TabIndex = 3;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(400, 199);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(101, 36);
            this.Stop.TabIndex = 4;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(712, 509);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Slower);
            this.Controls.Add(this.Faster);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button Faster;
        private System.Windows.Forms.Button Slower;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.ComponentModel.BackgroundWorker sender;
    }
}

