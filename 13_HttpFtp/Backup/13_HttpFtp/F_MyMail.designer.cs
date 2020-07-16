namespace _13_HttpFtp
{
    partial class F_MyMail
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbMailTitle = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbMailBody = new System.Windows.Forms.TextBox();
            this.tbMailTo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "邮件主题";
            // 
            // tbMailTitle
            // 
            this.tbMailTitle.Location = new System.Drawing.Point(74, 56);
            this.tbMailTitle.Name = "tbMailTitle";
            this.tbMailTitle.Size = new System.Drawing.Size(196, 21);
            this.tbMailTitle.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "发送";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbMailBody
            // 
            this.tbMailBody.Location = new System.Drawing.Point(20, 93);
            this.tbMailBody.Multiline = true;
            this.tbMailBody.Name = "tbMailBody";
            this.tbMailBody.Size = new System.Drawing.Size(331, 208);
            this.tbMailBody.TabIndex = 6;
            // 
            // tbMailTo
            // 
            this.tbMailTo.Location = new System.Drawing.Point(74, 16);
            this.tbMailTo.Name = "tbMailTo";
            this.tbMailTo.Size = new System.Drawing.Size(196, 21);
            this.tbMailTo.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "收件人";
            // 
            // MyMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 313);
            this.Controls.Add(this.tbMailTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMailBody);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbMailTitle);
            this.Controls.Add(this.label1);
            this.Name = "MyMail";
            this.Text = "MyMail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMailTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbMailBody;
        private System.Windows.Forms.TextBox tbMailTo;
        private System.Windows.Forms.Label label2;
    }
}