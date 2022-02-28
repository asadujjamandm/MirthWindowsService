
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseForm));
            this.serverTxt = new System.Windows.Forms.TextBox();
            this.loginNameTxt = new System.Windows.Forms.TextBox();
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
            this.ServerAutRadio = new System.Windows.Forms.RadioButton();
            this.WinAuthRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.messagelbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serverTxt
            // 
            this.serverTxt.Location = new System.Drawing.Point(181, 66);
            this.serverTxt.Name = "serverTxt";
            this.serverTxt.Size = new System.Drawing.Size(200, 20);
            this.serverTxt.TabIndex = 0;
            this.serverTxt.Validating += new System.ComponentModel.CancelEventHandler(this.serverTxt_Validating);
            // 
            // loginNameTxt
            // 
            this.loginNameTxt.Location = new System.Drawing.Point(181, 118);
            this.loginNameTxt.Name = "loginNameTxt";
            this.loginNameTxt.Size = new System.Drawing.Size(200, 20);
            this.loginNameTxt.TabIndex = 1;
            this.loginNameTxt.Validating += new System.ComponentModel.CancelEventHandler(this.loginName_Validating);
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(181, 144);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(200, 20);
            this.passwordTxt.TabIndex = 2;
            this.passwordTxt.Validating += new System.ComponentModel.CancelEventHandler(this.passwordTxt_Validating);
            // 
            // Server
            // 
            this.Server.AutoSize = true;
            this.Server.Location = new System.Drawing.Point(69, 69);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(38, 13);
            this.Server.TabIndex = 3;
            this.Server.Text = "Server";
            // 
            // DataSourceLbl
            // 
            this.DataSourceLbl.AutoSize = true;
            this.DataSourceLbl.Location = new System.Drawing.Point(69, 95);
            this.DataSourceLbl.Name = "DataSourceLbl";
            this.DataSourceLbl.Size = new System.Drawing.Size(67, 13);
            this.DataSourceLbl.TabIndex = 4;
            this.DataSourceLbl.Text = "Data Source";
            // 
            // loginlbl
            // 
            this.loginlbl.AutoSize = true;
            this.loginlbl.Location = new System.Drawing.Point(69, 121);
            this.loginlbl.Name = "loginlbl";
            this.loginlbl.Size = new System.Drawing.Size(64, 13);
            this.loginlbl.TabIndex = 5;
            this.loginlbl.Text = "Login Name";
            // 
            // dataSource
            // 
            this.dataSource.Location = new System.Drawing.Point(181, 92);
            this.dataSource.Name = "dataSource";
            this.dataSource.Size = new System.Drawing.Size(200, 20);
            this.dataSource.TabIndex = 7;
            this.dataSource.Validating += new System.ComponentModel.CancelEventHandler(this.dataSource_Validating);
            // 
            // passlbl
            // 
            this.passlbl.AutoSize = true;
            this.passlbl.Location = new System.Drawing.Point(69, 147);
            this.passlbl.Name = "passlbl";
            this.passlbl.Size = new System.Drawing.Size(53, 13);
            this.passlbl.TabIndex = 8;
            this.passlbl.Text = "Password";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(412, 341);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 9;
            this.nextButton.Text = "Next >";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(319, 341);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 10;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(306, 182);
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
            this.MessageLabel.Location = new System.Drawing.Point(70, 250);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(102, 17);
            this.MessageLabel.TabIndex = 12;
            this.MessageLabel.Text = "DSAASDDASD";
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(13, 9);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(461, 24);
            this.labelWelcome.TabIndex = 18;
            this.labelWelcome.Text = "Welcome to the Mirth Windows Service Installer Setup";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(-2, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(510, 3);
            this.label2.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(-2, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 3);
            this.label1.TabIndex = 20;
            // 
            // ServerAutRadio
            // 
            this.ServerAutRadio.AutoSize = true;
            this.ServerAutRadio.Checked = true;
            this.ServerAutRadio.Location = new System.Drawing.Point(71, 38);
            this.ServerAutRadio.Name = "ServerAutRadio";
            this.ServerAutRadio.Size = new System.Drawing.Size(127, 17);
            this.ServerAutRadio.TabIndex = 13;
            this.ServerAutRadio.TabStop = true;
            this.ServerAutRadio.Text = "Server Authentication";
            this.ServerAutRadio.UseVisualStyleBackColor = true;
            // 
            // WinAuthRadio
            // 
            this.WinAuthRadio.AutoSize = true;
            this.WinAuthRadio.Location = new System.Drawing.Point(208, 38);
            this.WinAuthRadio.Name = "WinAuthRadio";
            this.WinAuthRadio.Size = new System.Drawing.Size(140, 17);
            this.WinAuthRadio.TabIndex = 13;
            this.WinAuthRadio.Text = "Windows Authentication";
            this.WinAuthRadio.UseVisualStyleBackColor = true;
            this.WinAuthRadio.CheckedChanged += new System.EventHandler(this.WinAuthRadio_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ServerAutRadio);
            this.groupBox1.Controls.Add(this.serverTxt);
            this.groupBox1.Controls.Add(this.loginNameTxt);
            this.groupBox1.Controls.Add(this.passwordTxt);
            this.groupBox1.Controls.Add(this.WinAuthRadio);
            this.groupBox1.Controls.Add(this.Server);
            this.groupBox1.Controls.Add(this.DataSourceLbl);
            this.groupBox1.Controls.Add(this.MessageLabel);
            this.groupBox1.Controls.Add(this.loginlbl);
            this.groupBox1.Controls.Add(this.ConnectButton);
            this.groupBox1.Controls.Add(this.dataSource);
            this.groupBox1.Controls.Add(this.passlbl);
            this.groupBox1.Location = new System.Drawing.Point(17, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 217);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database Info";
            // 
            // messagelbl
            // 
            this.messagelbl.AutoSize = true;
            this.messagelbl.Location = new System.Drawing.Point(14, 273);
            this.messagelbl.Name = "messagelbl";
            this.messagelbl.Size = new System.Drawing.Size(0, 13);
            this.messagelbl.TabIndex = 22;
            // 
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 376);
            this.Controls.Add(this.messagelbl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.nextButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(515, 415);
            this.MinimumSize = new System.Drawing.Size(515, 415);
            this.Name = "DatabaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Info";
            this.Load += new System.EventHandler(this.DatabaseForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serverTxt;
        private System.Windows.Forms.TextBox loginNameTxt;
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
        private System.Windows.Forms.RadioButton ServerAutRadio;
        private System.Windows.Forms.RadioButton WinAuthRadio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label messagelbl;
    }
}

