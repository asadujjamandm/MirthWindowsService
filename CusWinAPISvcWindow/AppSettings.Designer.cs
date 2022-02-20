
namespace CusWinAPISvcWindow
{
    partial class AppSettings
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
            this.frequencylbl = new System.Windows.Forms.Label();
            this.frequencytxtBox = new System.Windows.Forms.TextBox();
            this.sourcePathTxtBox = new System.Windows.Forms.TextBox();
            this.sourcePathlbl = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cvsAPIURLlbl = new System.Windows.Forms.Label();
            this.destinationtxtBox = new System.Windows.Forms.TextBox();
            this.destinationPathlbl = new System.Windows.Forms.Label();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // frequencylbl
            // 
            this.frequencylbl.AutoSize = true;
            this.frequencylbl.Location = new System.Drawing.Point(100, 90);
            this.frequencylbl.Name = "frequencylbl";
            this.frequencylbl.Size = new System.Drawing.Size(57, 13);
            this.frequencylbl.TabIndex = 0;
            this.frequencylbl.Text = "Frequency";
            // 
            // frequencytxtBox
            // 
            this.frequencytxtBox.Location = new System.Drawing.Point(200, 90);
            this.frequencytxtBox.Name = "frequencytxtBox";
            this.frequencytxtBox.Size = new System.Drawing.Size(160, 20);
            this.frequencytxtBox.TabIndex = 1;
            // 
            // sourcePathTxtBox
            // 
            this.sourcePathTxtBox.Location = new System.Drawing.Point(200, 120);
            this.sourcePathTxtBox.Name = "sourcePathTxtBox";
            this.sourcePathTxtBox.Size = new System.Drawing.Size(160, 20);
            this.sourcePathTxtBox.TabIndex = 3;
            // 
            // sourcePathlbl
            // 
            this.sourcePathlbl.AutoSize = true;
            this.sourcePathlbl.Location = new System.Drawing.Point(100, 120);
            this.sourcePathlbl.Name = "sourcePathlbl";
            this.sourcePathlbl.Size = new System.Drawing.Size(66, 13);
            this.sourcePathlbl.TabIndex = 2;
            this.sourcePathlbl.Text = "Source Path";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(200, 180);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 20);
            this.textBox2.TabIndex = 7;
            // 
            // cvsAPIURLlbl
            // 
            this.cvsAPIURLlbl.AutoSize = true;
            this.cvsAPIURLlbl.Location = new System.Drawing.Point(100, 180);
            this.cvsAPIURLlbl.Name = "cvsAPIURLlbl";
            this.cvsAPIURLlbl.Size = new System.Drawing.Size(73, 13);
            this.cvsAPIURLlbl.TabIndex = 6;
            this.cvsAPIURLlbl.Text = "CVS API URL";
            // 
            // destinationtxtBox
            // 
            this.destinationtxtBox.Location = new System.Drawing.Point(200, 150);
            this.destinationtxtBox.Name = "destinationtxtBox";
            this.destinationtxtBox.Size = new System.Drawing.Size(160, 20);
            this.destinationtxtBox.TabIndex = 5;
            // 
            // destinationPathlbl
            // 
            this.destinationPathlbl.AutoSize = true;
            this.destinationPathlbl.Location = new System.Drawing.Point(100, 150);
            this.destinationPathlbl.Name = "destinationPathlbl";
            this.destinationPathlbl.Size = new System.Drawing.Size(85, 13);
            this.destinationPathlbl.TabIndex = 4;
            this.destinationPathlbl.Text = "Destination Path";
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(366, 302);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(75, 23);
            this.previousButton.TabIndex = 8;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(447, 302);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 9;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // AppSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.cvsAPIURLlbl);
            this.Controls.Add(this.destinationtxtBox);
            this.Controls.Add(this.destinationPathlbl);
            this.Controls.Add(this.sourcePathTxtBox);
            this.Controls.Add(this.sourcePathlbl);
            this.Controls.Add(this.frequencytxtBox);
            this.Controls.Add(this.frequencylbl);
            this.Name = "AppSettings";
            this.Text = "App Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label frequencylbl;
        private System.Windows.Forms.TextBox frequencytxtBox;
        private System.Windows.Forms.TextBox sourcePathTxtBox;
        private System.Windows.Forms.Label sourcePathlbl;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label cvsAPIURLlbl;
        private System.Windows.Forms.TextBox destinationtxtBox;
        private System.Windows.Forms.Label destinationPathlbl;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
    }
}