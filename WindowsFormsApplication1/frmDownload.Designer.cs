namespace WindowsFormsApplication1
{
    partial class frmDownload
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlink = new System.Windows.Forms.TextBox();
            this.rbtFTP = new System.Windows.Forms.RadioButton();
            this.rbtHTTP = new System.Windows.Forms.RadioButton();
            this.lblpass = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(280, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 25);
            this.button1.TabIndex = 13;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnclear);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(381, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 25);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.Location = new System.Drawing.Point(199, 185);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(71, 25);
            this.btnDownload.TabIndex = 8;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 37);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(164, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sample Application";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(37, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Link";
            // 
            // txtlink
            // 
            this.txtlink.Location = new System.Drawing.Point(132, 74);
            this.txtlink.Name = "txtlink";
            this.txtlink.Size = new System.Drawing.Size(351, 20);
            this.txtlink.TabIndex = 9;
            // 
            // rbtFTP
            // 
            this.rbtFTP.AutoSize = true;
            this.rbtFTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtFTP.Location = new System.Drawing.Point(29, 168);
            this.rbtFTP.Name = "rbtFTP";
            this.rbtFTP.Size = new System.Drawing.Size(40, 17);
            this.rbtFTP.TabIndex = 14;
            this.rbtFTP.TabStop = true;
            this.rbtFTP.Text = "ftp";
            this.rbtFTP.UseVisualStyleBackColor = true;
            this.rbtFTP.CheckedChanged += new System.EventHandler(this.rbtFTP_CheckedChanged);
            // 
            // rbtHTTP
            // 
            this.rbtHTTP.AutoSize = true;
            this.rbtHTTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtHTTP.Location = new System.Drawing.Point(29, 193);
            this.rbtHTTP.Name = "rbtHTTP";
            this.rbtHTTP.Size = new System.Drawing.Size(47, 17);
            this.rbtHTTP.TabIndex = 15;
            this.rbtHTTP.TabStop = true;
            this.rbtHTTP.Text = "http";
            this.rbtHTTP.UseVisualStyleBackColor = true;
            this.rbtHTTP.CheckedChanged += new System.EventHandler(this.rbtHTTP_CheckedChanged);
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.ForeColor = System.Drawing.Color.Gray;
            this.lblpass.Location = new System.Drawing.Point(288, 120);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(77, 17);
            this.lblpass.TabIndex = 16;
            this.lblpass.Text = "Password";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.Gray;
            this.lblname.Location = new System.Drawing.Point(37, 124);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(88, 17);
            this.lblname.TabIndex = 17;
            this.lblname.Text = "User Name";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(383, 117);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(100, 20);
            this.txtpass.TabIndex = 18;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(132, 117);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(119, 20);
            this.txtname.TabIndex = 19;
            // 
            // frmDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 231);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.rbtHTTP);
            this.Controls.Add(this.rbtFTP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtlink);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDownload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDownload";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtlink;
        private System.Windows.Forms.RadioButton rbtFTP;
        private System.Windows.Forms.RadioButton rbtHTTP;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtname;
    }
}