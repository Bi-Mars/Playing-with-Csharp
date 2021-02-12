namespace InternetPlay
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
            this.usrname = new System.Windows.Forms.TextBox();
            this.uname = new System.Windows.Forms.Label();
            this.usrpass = new System.Windows.Forms.TextBox();
            this.pword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbRemote = new System.Windows.Forms.ListBox();
            this.lbServer = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // usrname
            // 
            this.usrname.Font = new System.Drawing.Font("Consolas", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrname.Location = new System.Drawing.Point(139, 23);
            this.usrname.Name = "usrname";
            this.usrname.Size = new System.Drawing.Size(210, 33);
            this.usrname.TabIndex = 3;
            // 
            // uname
            // 
            this.uname.AutoSize = true;
            this.uname.Font = new System.Drawing.Font("Consolas", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uname.Location = new System.Drawing.Point(12, 17);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(108, 26);
            this.uname.TabIndex = 4;
            this.uname.Text = "UserName";
            // 
            // usrpass
            // 
            this.usrpass.Font = new System.Drawing.Font("Consolas", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrpass.Location = new System.Drawing.Point(139, 64);
            this.usrpass.Name = "usrpass";
            this.usrpass.Size = new System.Drawing.Size(210, 33);
            this.usrpass.TabIndex = 5;
            this.usrpass.UseSystemPasswordChar = true;
            this.usrpass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.usrpass_KeyUp);
            // 
            // pword
            // 
            this.pword.AutoSize = true;
            this.pword.Font = new System.Drawing.Font("Consolas", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pword.Location = new System.Drawing.Point(12, 64);
            this.pword.Name = "pword";
            this.pword.Size = new System.Drawing.Size(108, 26);
            this.pword.TabIndex = 6;
            this.pword.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Files in Your Computer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(483, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Files in Server";
            // 
            // lbRemote
            // 
            this.lbRemote.FormattingEnabled = true;
            this.lbRemote.ItemHeight = 16;
            this.lbRemote.Location = new System.Drawing.Point(17, 133);
            this.lbRemote.Name = "lbRemote";
            this.lbRemote.Size = new System.Drawing.Size(242, 324);
            this.lbRemote.TabIndex = 10;
            this.lbRemote.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbRemote_DragDrop);
            this.lbRemote.DragOver += new System.Windows.Forms.DragEventHandler(this.lbRemote_DragOver);
            this.lbRemote.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbRemote_MouseDown);
            // 
            // lbServer
            // 
            this.lbServer.FormattingEnabled = true;
            this.lbServer.ItemHeight = 16;
            this.lbServer.Location = new System.Drawing.Point(463, 133);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(212, 308);
            this.lbServer.TabIndex = 11;
            this.lbServer.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbServer_DragDrop);
            this.lbServer.DragOver += new System.Windows.Forms.DragEventHandler(this.lbServer_DragOver);
            this.lbServer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbServer_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.lbServer);
            this.Controls.Add(this.lbRemote);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pword);
            this.Controls.Add(this.usrpass);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.usrname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox usrname;
        private System.Windows.Forms.Label uname;
        private System.Windows.Forms.TextBox usrpass;
        private System.Windows.Forms.Label pword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbRemote;
        private System.Windows.Forms.ListBox lbServer;
    }
}

