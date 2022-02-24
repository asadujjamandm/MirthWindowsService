
namespace CusWinAPISvcWindow
{
    partial class DatabaseForm
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
            this.serverTxt = new System.Windows.Forms.TextBox();
            this.loginName = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.Server = new System.Windows.Forms.Label();
            this.DataSourceLbl = new System.Windows.Forms.Label();
            this.loginlbl = new System.Windows.Forms.Label();
            this.dataSource = new System.Windows.Forms.TextBox();
            this.passlbl = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // serverTxt
            // 
            this.serverTxt.Location = new System.Drawing.Point(138, 80);
            this.serverTxt.Name = "serverTxt";
            this.serverTxt.Size = new System.Drawing.Size(180, 20);
            this.serverTxt.TabIndex = 0;
            this.serverTxt.Validating += new System.ComponentModel.CancelEventHandler(this.serverTxt_Validating);
            // 
            // loginName
            // 
            this.loginName.Location = new System.Drawing.Point(138, 132);
            this.loginName.Name = "loginName";
            this.loginName.Size = new System.Drawing.Size(180, 20);
            this.loginName.TabIndex = 1;
            this.loginName.Validating += new System.ComponentModel.CancelEventHandler(this.loginName_Validating);
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(138, 158);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(180, 20);
            this.passwordTxt.TabIndex = 2;
            this.passwordTxt.Validating += new System.ComponentModel.CancelEventHandler(this.passwordTxt_Validating);
            // 
            // Server
            // 
            this.Server.AutoSize = true;
            this.Server.Location = new System.Drawing.Point(26, 83);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(38, 13);
            this.Server.TabIndex = 3;
            this.Server.Text = "Server";
            // 
            // DataSourceLbl
            // 
            this.DataSourceLbl.AutoSize = true;
            this.DataSourceLbl.Location = new System.Drawing.Point(26, 109);
            this.DataSourceLbl.Name = "DataSourceLbl";
            this.DataSourceLbl.Size = new System.Drawing.Size(67, 13);
            this.DataSourceLbl.TabIndex = 4;
            this.DataSourceLbl.Text = "Data Source";
            // 
            // loginlbl
            // 
            this.loginlbl.AutoSize = true;
            this.loginlbl.Location = new System.Drawing.Point(26, 135);
            this.loginlbl.Name = "loginlbl";
            this.loginlbl.Size = new System.Drawing.Size(64, 13);
            this.loginlbl.TabIndex = 5;
            this.loginlbl.Text = "Login Name";
            // 
            // dataSource
            // 
            this.dataSource.Location = new System.Drawing.Point(138, 106);
            this.dataSource.Name = "dataSource";
            this.dataSource.Size = new System.Drawing.Size(180, 20);
            this.dataSource.TabIndex = 7;
            this.dataSource.Validating += new System.ComponentModel.CancelEventHandler(this.dataSource_Validating);
            // 
            // passlbl
            // 
            this.passlbl.AutoSize = true;
            this.passlbl.Location = new System.Drawing.Point(26, 161);
            this.passlbl.Name = "passlbl";
            this.passlbl.Size = new System.Drawing.Size(53, 13);
            this.passlbl.TabIndex = 8;
            this.passlbl.Text = "Password";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(336, 274);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 9;
            this.nextButton.Text = "Next >";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(243, 274);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 10;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(243, 196);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 11;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLabel.Location = new System.Drawing.Point(82, 233);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(0, 17);
            this.MessageLabel.TabIndex = 12;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(25, 9);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(386, 20);
            this.labelWelcome.TabIndex = 18;
            this.labelWelcome.Text = "Welcone to the Mirth Windows Service Installer Setup";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(-2, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(440, 3);
            this.label2.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(-2, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 3);
            this.label1.TabIndex = 20;
            // 
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.passlbl);
            this.Controls.Add(this.dataSource);
            this.Controls.Add(this.loginlbl);
            this.Controls.Add(this.DataSourceLbl);
            this.Controls.Add(this.Server);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.loginName);
            this.Controls.Add(this.serverTxt);
            this.Name = "DatabaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Info";
            this.Load += new System.EventHandler(this.DatabaseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serverTxt;
        private System.Windows.Forms.TextBox loginName;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label Server;
        private System.Windows.Forms.Label DataSourceLbl;
        private System.Windows.Forms.Label loginlbl;
        private System.Windows.Forms.TextBox dataSource;
        private System.Windows.Forms.Label passlbl;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

