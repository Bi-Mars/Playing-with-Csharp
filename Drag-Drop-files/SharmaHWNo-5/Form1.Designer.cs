namespace SharmaHWNo_5
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
            this.LSBox1 = new System.Windows.Forms.ListBox();
            this.LSBox2 = new System.Windows.Forms.ListBox();
            this.mvFile = new System.Windows.Forms.RadioButton();
            this.cpFile = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // LSBox1
            // 
            this.LSBox1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSBox1.FormattingEnabled = true;
            this.LSBox1.ItemHeight = 20;
            this.LSBox1.Location = new System.Drawing.Point(124, 185);
            this.LSBox1.Name = "LSBox1";
            this.LSBox1.Size = new System.Drawing.Size(222, 184);
            this.LSBox1.TabIndex = 0;
            this.LSBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.LSBox1_DragDrop);
            this.LSBox1.DragOver += new System.Windows.Forms.DragEventHandler(this.LSBox1_DragOver);
            this.LSBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LSBox1_MouseDown);
            // 
            // LSBox2
            // 
            this.LSBox2.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSBox2.FormattingEnabled = true;
            this.LSBox2.ItemHeight = 22;
            this.LSBox2.Location = new System.Drawing.Point(480, 185);
            this.LSBox2.Name = "LSBox2";
            this.LSBox2.Size = new System.Drawing.Size(226, 180);
            this.LSBox2.TabIndex = 1;
            this.LSBox2.DragDrop += new System.Windows.Forms.DragEventHandler(this.LSBox2_DragDrop);
            this.LSBox2.DragOver += new System.Windows.Forms.DragEventHandler(this.LSBox2_DragOver);
            this.LSBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LSBox2_MouseDown);
            // 
            // mvFile
            // 
            this.mvFile.AutoSize = true;
            this.mvFile.Location = new System.Drawing.Point(308, 46);
            this.mvFile.Name = "mvFile";
            this.mvFile.Size = new System.Drawing.Size(148, 21);
            this.mvFile.TabIndex = 2;
            this.mvFile.TabStop = true;
            this.mvFile.Text = "Move Dragged File";
            this.mvFile.UseVisualStyleBackColor = true;
            // 
            // cpFile
            // 
            this.cpFile.AutoSize = true;
            this.cpFile.Location = new System.Drawing.Point(308, 74);
            this.cpFile.Name = "cpFile";
            this.cpFile.Size = new System.Drawing.Size(146, 21);
            this.cpFile.TabIndex = 3;
            this.cpFile.TabStop = true;
            this.cpFile.Text = "Copy Dragged File";
            this.cpFile.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cpFile);
            this.Controls.Add(this.mvFile);
            this.Controls.Add(this.LSBox2);
            this.Controls.Add(this.LSBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LSBox1;
        private System.Windows.Forms.ListBox LSBox2;
        private System.Windows.Forms.RadioButton mvFile;
        private System.Windows.Forms.RadioButton cpFile;
    }
}

