namespace ServerProgram
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
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.bgConnect = new System.ComponentModel.BackgroundWorker();
            this.bgSocket = new System.ComponentModel.BackgroundWorker();
            this.richResponse = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(21, 233);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(532, 22);
            this.txtMessage.TabIndex = 1;
            this.txtMessage.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyUp);
            // 
            // bgConnect
            // 
            this.bgConnect.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgConnect_DoWork);
            this.bgConnect.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgConnect_RunWorkerCompleted);
            // 
            // bgSocket
            // 
            this.bgSocket.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgSocket_DoWork);
            this.bgSocket.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgSocket_RunWorkerCompleted);
            // 
            // richResponse
            // 
            this.richResponse.Location = new System.Drawing.Point(12, 23);
            this.richResponse.Name = "richResponse";
            this.richResponse.Size = new System.Drawing.Size(541, 177);
            this.richResponse.TabIndex = 2;
            this.richResponse.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richResponse);
            this.Controls.Add(this.txtMessage);
            this.Name = "Form1";
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMessage;
        private System.ComponentModel.BackgroundWorker bgConnect;
        private System.ComponentModel.BackgroundWorker bgSocket;
        private System.Windows.Forms.RichTextBox richResponse;
    }
}

