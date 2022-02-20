
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
            this.SuspendLayout();
            // 
            // serverTxt
            // 
            this.serverTxt.Location = new System.Drawing.Point(173, 65);
            this.serverTxt.Name = "serverTxt";
            this.serverTxt.Size = new System.Drawing.Size(150, 20);
            this.serverTxt.TabIndex = 0;
            // 
            // loginName
            // 
            this.loginName.Location = new System.Drawing.Point(173, 117);
            this.loginName.Name = "loginName";
            this.loginName.Size = new System.Drawing.Size(150, 20);
            this.loginName.TabIndex = 1;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(173, 143);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(150, 20);
            this.passwordTxt.TabIndex = 2;
            // 
            // Server
            // 
            this.Server.AutoSize = true;
            this.Server.Location = new System.Drawing.Point(58, 68);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(38, 13);
            this.Server.TabIndex = 3;
            this.Server.Text = "Server";
            // 
            // DataSourceLbl
            // 
            this.DataSourceLbl.AutoSize = true;
            this.DataSourceLbl.Location = new System.Drawing.Point(58, 94);
            this.DataSourceLbl.Name = "DataSourceLbl";
            this.DataSourceLbl.Size = new System.Drawing.Size(67, 13);
            this.DataSourceLbl.TabIndex = 4;
            this.DataSourceLbl.Text = "Data Source";
            // 
            // loginlbl
            // 
            this.loginlbl.AutoSize = true;
            this.loginlbl.Location = new System.Drawing.Point(58, 120);
            this.loginlbl.Name = "loginlbl";
            this.loginlbl.Size = new System.Drawing.Size(64, 13);
            this.loginlbl.TabIndex = 5;
            this.loginlbl.Text = "Login Name";
            // 
            // dataSource
            // 
            this.dataSource.Location = new System.Drawing.Point(173, 91);
            this.dataSource.Name = "dataSource";
            this.dataSource.Size = new System.Drawing.Size(150, 20);
            this.dataSource.TabIndex = 7;
            // 
            // passlbl
            // 
            this.passlbl.AutoSize = true;
            this.passlbl.Location = new System.Drawing.Point(58, 146);
            this.passlbl.Name = "passlbl";
            this.passlbl.Size = new System.Drawing.Size(53, 13);
            this.passlbl.TabIndex = 8;
            this.passlbl.Text = "Password";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(479, 289);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 9;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(398, 289);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 10;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Text = "Database Info";
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
    }
}

