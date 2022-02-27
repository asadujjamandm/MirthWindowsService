
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
            this.loginName = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.Server = new System.Windows.Forms.Label();
            this.DataSourceLbl = new System.Windows.Forms.Label();
            this.loginlbl = new System.Windows.Forms.Label();
            this.dataSource = new System.Windows.Forms.TextBox();
            this.passlbl = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.grpBoxDbInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serverTxt
            // 
            this.serverTxt.Location = new System.Drawing.Point(121, 44);
            this.serverTxt.Name = "serverTxt";
            this.serverTxt.Size = new System.Drawing.Size(241, 20);
            this.serverTxt.TabIndex = 0;
            // 
            // loginName
            // 
            this.loginName.Location = new System.Drawing.Point(121, 96);
            this.loginName.Name = "loginName";
            this.loginName.Size = new System.Drawing.Size(241, 20);
            this.loginName.TabIndex = 1;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(121, 122);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(241, 20);
            this.passwordTxt.TabIndex = 2;
            // 
            // Server
            // 
            this.Server.AutoSize = true;
            this.Server.Location = new System.Drawing.Point(6, 47);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(38, 13);
            this.Server.TabIndex = 3;
            this.Server.Text = "Server";
            // 
            // DataSourceLbl
            // 
            this.DataSourceLbl.AutoSize = true;
            this.DataSourceLbl.Location = new System.Drawing.Point(6, 73);
            this.DataSourceLbl.Name = "DataSourceLbl";
            this.DataSourceLbl.Size = new System.Drawing.Size(67, 13);
            this.DataSourceLbl.TabIndex = 4;
            this.DataSourceLbl.Text = "Data Source";
            // 
            // loginlbl
            // 
            this.loginlbl.AutoSize = true;
            this.loginlbl.Location = new System.Drawing.Point(6, 99);
            this.loginlbl.Name = "loginlbl";
            this.loginlbl.Size = new System.Drawing.Size(64, 13);
            this.loginlbl.TabIndex = 5;
            this.loginlbl.Text = "Login Name";
            // 
            // dataSource
            // 
            this.dataSource.Location = new System.Drawing.Point(121, 70);
            this.dataSource.Name = "dataSource";
            this.dataSource.Size = new System.Drawing.Size(241, 20);
            this.dataSource.TabIndex = 7;
            // 
            // passlbl
            // 
            this.passlbl.AutoSize = true;
            this.passlbl.Location = new System.Drawing.Point(6, 125);
            this.passlbl.Name = "passlbl";
            this.passlbl.Size = new System.Drawing.Size(53, 13);
            this.passlbl.TabIndex = 8;
            this.passlbl.Text = "Password";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(391, 326);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 10;
            this.nextButton.Text = "Next >";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(299, 326);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 10;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // grpBoxDbInfo
            // 
            this.grpBoxDbInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grpBoxDbInfo.Location = new System.Drawing.Point(-4, 56);
            this.grpBoxDbInfo.Name = "grpBoxDbInfo";
            this.grpBoxDbInfo.Size = new System.Drawing.Size(510, 3);
            this.grpBoxDbInfo.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 3);
            this.label1.TabIndex = 15;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(25, 22);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(386, 20);
            this.labelWelcome.TabIndex = 18;
            this.labelWelcome.Text = "Welcone to the Mirth Windows Service Installer Setup";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Server);
            this.groupBox1.Controls.Add(this.serverTxt);
            this.groupBox1.Controls.Add(this.loginName);
            this.groupBox1.Controls.Add(this.passwordTxt);
            this.groupBox1.Controls.Add(this.DataSourceLbl);
            this.groupBox1.Controls.Add(this.loginlbl);
            this.groupBox1.Controls.Add(this.passlbl);
            this.groupBox1.Controls.Add(this.dataSource);
            this.groupBox1.Location = new System.Drawing.Point(29, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 215);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database Info";
            // 
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 371);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpBoxDbInfo);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.nextButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DatabaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Info";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label grpBoxDbInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

