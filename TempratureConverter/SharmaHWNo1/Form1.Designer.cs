namespace SharmaHWNo1
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
            this.ForC = new System.Windows.Forms.GroupBox();
            this.CtoF = new System.Windows.Forms.RadioButton();
            this.FtoC = new System.Windows.Forms.RadioButton();
            this.text1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.calc_butt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.Label();
            this.ForC.SuspendLayout();
            this.SuspendLayout();
            // 
            // ForC
            // 
            this.ForC.Controls.Add(this.CtoF);
            this.ForC.Controls.Add(this.FtoC);
            this.ForC.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForC.Location = new System.Drawing.Point(79, 10);
            this.ForC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ForC.Name = "ForC";
            this.ForC.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ForC.Size = new System.Drawing.Size(325, 130);
            this.ForC.TabIndex = 0;
            this.ForC.TabStop = false;
            this.ForC.Text = "Fahrenheit or Centigrade";
            // 
            // CtoF
            // 
            this.CtoF.AutoSize = true;
            this.CtoF.Location = new System.Drawing.Point(79, 62);
            this.CtoF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CtoF.Name = "CtoF";
            this.CtoF.Size = new System.Drawing.Size(204, 23);
            this.CtoF.TabIndex = 1;
            this.CtoF.TabStop = true;
            this.CtoF.Text = "Centigrade To Fahrenheit";
            this.CtoF.UseVisualStyleBackColor = true;
            this.CtoF.CheckedChanged += new System.EventHandler(this.CtoF_CheckedChanged);
            this.CtoF.Click += new System.EventHandler(this.CtoF_Click);
            // 
            // FtoC
            // 
            this.FtoC.AutoSize = true;
            this.FtoC.Location = new System.Drawing.Point(79, 34);
            this.FtoC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FtoC.Name = "FtoC";
            this.FtoC.Size = new System.Drawing.Size(204, 23);
            this.FtoC.TabIndex = 0;
            this.FtoC.TabStop = true;
            this.FtoC.Text = "Fahrenheit To Centigrade";
            this.FtoC.UseVisualStyleBackColor = true;
            this.FtoC.CheckedChanged += new System.EventHandler(this.FtoC_CheckedChanged);
            this.FtoC.Click += new System.EventHandler(this.FtoC_Click);
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text1.Location = new System.Drawing.Point(215, 173);
            this.text1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(61, 19);
            this.text1.TabIndex = 1;
            this.text1.Text = "             ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 173);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter the temperature in ";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(308, 173);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 25);
            this.textBox1.TabIndex = 3;
            // 
            // calc_butt
            // 
            this.calc_butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calc_butt.Location = new System.Drawing.Point(248, 227);
            this.calc_butt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calc_butt.Name = "calc_butt";
            this.calc_butt.Size = new System.Drawing.Size(145, 40);
            this.calc_butt.TabIndex = 4;
            this.calc_butt.Text = "Calculate";
            this.calc_butt.UseVisualStyleBackColor = true;
            this.calc_butt.Click += new System.EventHandler(this.Calc_butt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 305);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "The degree in  ";
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text2.Location = new System.Drawing.Point(154, 305);
            this.text2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(61, 19);
            this.text2.TabIndex = 6;
            this.text2.Text = "             ";
            // 
            // textBox2
            // 
            this.textBox2.AutoSize = true;
            this.textBox2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(244, 305);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(61, 19);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "             ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 414);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calc_butt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.ForC);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Degree Converter";
            this.ForC.ResumeLayout(false);
            this.ForC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ForC;
        private System.Windows.Forms.RadioButton CtoF;
        private System.Windows.Forms.RadioButton FtoC;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button calc_butt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.Label textBox2;
    }
}

