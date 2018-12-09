namespace ThresholdBackup
{
    partial class backupConfirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(backupConfirm));
            this.beginBackup = new System.Windows.Forms.Button();
            this.cancelClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.progressText = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // beginBackup
            // 
            this.beginBackup.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginBackup.Location = new System.Drawing.Point(15, 121);
            this.beginBackup.Name = "beginBackup";
            this.beginBackup.Size = new System.Drawing.Size(279, 77);
            this.beginBackup.TabIndex = 0;
            this.beginBackup.Text = "Begin";
            this.beginBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.beginBackup.UseVisualStyleBackColor = true;
            this.beginBackup.Click += new System.EventHandler(this.beginBackup_Click);
            // 
            // cancelClose
            // 
            this.cancelClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cancelClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelClose.Location = new System.Drawing.Point(312, 121);
            this.cancelClose.Name = "cancelClose";
            this.cancelClose.Size = new System.Drawing.Size(259, 77);
            this.cancelClose.TabIndex = 1;
            this.cancelClose.Text = "Close / Cancel";
            this.cancelClose.UseVisualStyleBackColor = true;
            this.cancelClose.Click += new System.EventHandler(this.cancelClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(246, 20);
            this.label1.MinimumSize = new System.Drawing.Size(300, 20);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(300, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source Directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(246, 70);
            this.label2.MinimumSize = new System.Drawing.Size(300, 20);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10);
            this.label2.Size = new System.Drawing.Size(300, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination Directory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 20);
            this.label3.MinimumSize = new System.Drawing.Size(200, 20);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10);
            this.label3.Size = new System.Drawing.Size(200, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "Backup Source";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 70);
            this.label4.MinimumSize = new System.Drawing.Size(200, 20);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10);
            this.label4.Size = new System.Drawing.Size(200, 35);
            this.label4.TabIndex = 5;
            this.label4.Text = "Destination Directory";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(15, 204);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(556, 28);
            this.progressBar.TabIndex = 6;
            // 
            // progressText
            // 
            this.progressText.AutoSize = true;
            this.progressText.Location = new System.Drawing.Point(281, 235);
            this.progressText.Name = "progressText";
            this.progressText.Size = new System.Drawing.Size(13, 13);
            this.progressText.TabIndex = 7;
            this.progressText.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "/ 100";
            // 
            // backupConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(580, 257);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progressText);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelClose);
            this.Controls.Add(this.beginBackup);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "backupConfirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup Confirm";
            this.Load += new System.EventHandler(this.backupConfirm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button beginBackup;
        private System.Windows.Forms.Button cancelClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label progressText;
        private System.Windows.Forms.Label label5;
    }
}