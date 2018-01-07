namespace CSharpClient
{
    partial class FormMailer
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
            this.textLogin = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textSubject = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.textMessage = new System.Windows.Forms.RichTextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.textPort = new System.Windows.Forms.TextBox();
            this.textServer = new System.Windows.Forms.TextBox();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.textFileDirection = new System.Windows.Forms.TextBox();
            this.lblFileDirection = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLog = new System.Windows.Forms.Label();
            this.chbxUseSSL = new System.Windows.Forms.CheckBox();
            this.lblUseSSL = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textLogin
            // 
            this.textLogin.Location = new System.Drawing.Point(160, 49);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(153, 22);
            this.textLogin.TabIndex = 0;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(160, 77);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(153, 22);
            this.textPassword.TabIndex = 1;
            this.textPassword.UseSystemPasswordChar = true;
            // 
            // textSubject
            // 
            this.textSubject.Location = new System.Drawing.Point(489, 36);
            this.textSubject.Name = "textSubject";
            this.textSubject.Size = new System.Drawing.Size(419, 22);
            this.textSubject.TabIndex = 2;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLogin.Location = new System.Drawing.Point(111, 52);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(43, 17);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Login";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPassword.Location = new System.Drawing.Point(85, 80);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(489, 67);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(419, 375);
            this.textMessage.TabIndex = 5;
            this.textMessage.Text = "";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(418, 70);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(65, 17);
            this.lblMessage.TabIndex = 6;
            this.lblMessage.Text = "Message";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(428, 36);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(55, 17);
            this.lblSubject.TabIndex = 7;
            this.lblSubject.Text = "Subject";
            this.lblSubject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(277, 320);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 40);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPort.Location = new System.Drawing.Point(69, 100);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(34, 17);
            this.lblPort.TabIndex = 12;
            this.lblPort.Text = "Port";
            this.lblPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblServer.Location = new System.Drawing.Point(62, 108);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(92, 17);
            this.lblServer.TabIndex = 11;
            this.lblServer.Text = "SMTP Server";
            this.lblServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(160, 133);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(153, 22);
            this.textPort.TabIndex = 10;
            this.textPort.Text = "587";
            // 
            // textServer
            // 
            this.textServer.Location = new System.Drawing.Point(160, 105);
            this.textServer.Name = "textServer";
            this.textServer.Size = new System.Drawing.Size(153, 22);
            this.textServer.TabIndex = 9;
            this.textServer.Text = "smtp.gmail.com";
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(215, 148);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(47, 23);
            this.btnChooseFile.TabIndex = 13;
            this.btnChooseFile.Text = "...";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click_1);
            // 
            // textFileDirection
            // 
            this.textFileDirection.Location = new System.Drawing.Point(109, 148);
            this.textFileDirection.Name = "textFileDirection";
            this.textFileDirection.Size = new System.Drawing.Size(100, 22);
            this.textFileDirection.TabIndex = 14;
            // 
            // lblFileDirection
            // 
            this.lblFileDirection.AutoSize = true;
            this.lblFileDirection.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblFileDirection.Location = new System.Drawing.Point(13, 151);
            this.lblFileDirection.Name = "lblFileDirection";
            this.lblFileDirection.Size = new System.Drawing.Size(90, 17);
            this.lblFileDirection.TabIndex = 15;
            this.lblFileDirection.Text = "File Direction";
            this.lblFileDirection.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(109, 176);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(153, 40);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(109, 222);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(153, 40);
            this.btnDefault.TabIndex = 17;
            this.btnDefault.Text = "Default";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(51, 320);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 40);
            this.btnConnect.TabIndex = 18;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblUseSSL);
            this.panel1.Controls.Add(this.chbxUseSSL);
            this.panel1.Controls.Add(this.lblPort);
            this.panel1.Controls.Add(this.btnDefault);
            this.panel1.Controls.Add(this.lblFileDirection);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnChooseFile);
            this.panel1.Controls.Add(this.textFileDirection);
            this.panel1.Location = new System.Drawing.Point(51, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 278);
            this.panel1.TabIndex = 19;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(51, 424);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(32, 17);
            this.lblLog.TabIndex = 20;
            this.lblLog.Text = "Log";
            // 
            // chbxUseSSL
            // 
            this.chbxUseSSL.AutoSize = true;
            this.chbxUseSSL.Location = new System.Drawing.Point(109, 125);
            this.chbxUseSSL.Name = "chbxUseSSL";
            this.chbxUseSSL.Size = new System.Drawing.Size(18, 17);
            this.chbxUseSSL.TabIndex = 21;
            this.chbxUseSSL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbxUseSSL.UseVisualStyleBackColor = true;
            // 
            // lblUseSSL
            // 
            this.lblUseSSL.AutoSize = true;
            this.lblUseSSL.Location = new System.Drawing.Point(40, 124);
            this.lblUseSSL.Name = "lblUseSSL";
            this.lblUseSSL.Size = new System.Drawing.Size(63, 17);
            this.lblUseSSL.TabIndex = 22;
            this.lblUseSSL.Text = "Use SSL";
            this.lblUseSSL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormMailer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 509);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.textServer);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.textSubject);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textLogin);
            this.Controls.Add(this.panel1);
            this.Name = "FormMailer";
            this.Text = "CSharp Message Client";
            this.Load += new System.EventHandler(this.FormMailer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textSubject;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.RichTextBox textMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.TextBox textServer;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.TextBox textFileDirection;
        private System.Windows.Forms.Label lblFileDirection;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Label lblUseSSL;
        private System.Windows.Forms.CheckBox chbxUseSSL;
    }
}

