namespace hMSSql
{
    partial class MainFrm
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
            this.bt_close = new System.Windows.Forms.Button();
            this.sql_pad = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_connect = new System.Windows.Forms.Button();
            this.ed_usr = new System.Windows.Forms.TextBox();
            this.ed_pwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_status = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_close
            // 
            this.bt_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_close.Location = new System.Drawing.Point(500, 502);
            this.bt_close.Name = "bt_close";
            this.bt_close.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bt_close.Size = new System.Drawing.Size(114, 35);
            this.bt_close.TabIndex = 0;
            this.bt_close.Text = "Quit";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.button1_Click);
            // 
            // sql_pad
            // 
            this.sql_pad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sql_pad.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sql_pad.ForeColor = System.Drawing.SystemColors.Desktop;
            this.sql_pad.Location = new System.Drawing.Point(41, 130);
            this.sql_pad.Name = "sql_pad";
            this.sql_pad.Size = new System.Drawing.Size(579, 328);
            this.sql_pad.TabIndex = 2;
            this.sql_pad.Text = "delete from hm_messages where messagefrom like \'test01@incubator.net.projects\'";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sql Statement";
            // 
            // bt_connect
            // 
            this.bt_connect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_connect.Location = new System.Drawing.Point(41, 502);
            this.bt_connect.Name = "bt_connect";
            this.bt_connect.Size = new System.Drawing.Size(98, 35);
            this.bt_connect.TabIndex = 4;
            this.bt_connect.Text = "Execute";
            this.bt_connect.UseVisualStyleBackColor = true;
            this.bt_connect.Click += new System.EventHandler(this.bt_connect_Click);
            // 
            // ed_usr
            // 
            this.ed_usr.Location = new System.Drawing.Point(41, 56);
            this.ed_usr.Name = "ed_usr";
            this.ed_usr.Size = new System.Drawing.Size(200, 22);
            this.ed_usr.TabIndex = 5;
            this.ed_usr.Text = "Administrator";
            // 
            // ed_pwd
            // 
            this.ed_pwd.Location = new System.Drawing.Point(275, 56);
            this.ed_pwd.Name = "ed_pwd";
            this.ed_pwd.PasswordChar = '*';
            this.ed_pwd.Size = new System.Drawing.Size(192, 22);
            this.ed_pwd.TabIndex = 6;
            this.ed_pwd.Text = "test123";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(272, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password:";
            // 
            // lb_status
            // 
            this.lb_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_status.AutoSize = true;
            this.lb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_status.Location = new System.Drawing.Point(41, 471);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(59, 17);
            this.lb_status.TabIndex = 9;
            this.lb_status.Text = "Status:";
            this.lb_status.Click += new System.EventHandler(this.lb_status_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(163, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "Load SQL-Script";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 574);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ed_pwd);
            this.Controls.Add(this.ed_usr);
            this.Controls.Add(this.bt_connect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sql_pad);
            this.Controls.Add(this.bt_close);
            this.Name = "MainFrm";
            this.Text = "hMSSqlPad";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.RichTextBox sql_pad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_connect;
        private System.Windows.Forms.TextBox ed_usr;
        private System.Windows.Forms.TextBox ed_pwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.Button button1;
    }
}

