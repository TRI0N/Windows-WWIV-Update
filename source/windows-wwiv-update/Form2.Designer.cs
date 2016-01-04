namespace windows_wwiv_update
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.wwivStatus = new System.Windows.Forms.Label();
            this.telnetStatus = new System.Windows.Forms.Label();
            this.netStatus = new System.Windows.Forms.Label();
            this.infoStatus = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.versionNumber = new System.Windows.Forms.Label();
            this.spinStatus = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.updateComplete = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spinStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Updating WWIV 5 to Build:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(179, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "fetchVersion";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Restart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(178, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "NETWORK:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "WWIV:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(98, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "TELNET:";
            // 
            // wwivStatus
            // 
            this.wwivStatus.AutoSize = true;
            this.wwivStatus.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wwivStatus.ForeColor = System.Drawing.Color.Red;
            this.wwivStatus.Location = new System.Drawing.Point(47, 80);
            this.wwivStatus.Name = "wwivStatus";
            this.wwivStatus.Size = new System.Drawing.Size(38, 13);
            this.wwivStatus.TabIndex = 19;
            this.wwivStatus.Text = "STATUS";
            // 
            // telnetStatus
            // 
            this.telnetStatus.AutoSize = true;
            this.telnetStatus.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telnetStatus.ForeColor = System.Drawing.Color.Red;
            this.telnetStatus.Location = new System.Drawing.Point(135, 80);
            this.telnetStatus.Name = "telnetStatus";
            this.telnetStatus.Size = new System.Drawing.Size(38, 13);
            this.telnetStatus.TabIndex = 20;
            this.telnetStatus.Text = "STATUS";
            // 
            // netStatus
            // 
            this.netStatus.AutoSize = true;
            this.netStatus.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netStatus.ForeColor = System.Drawing.Color.Red;
            this.netStatus.Location = new System.Drawing.Point(230, 80);
            this.netStatus.Name = "netStatus";
            this.netStatus.Size = new System.Drawing.Size(38, 13);
            this.netStatus.TabIndex = 21;
            this.netStatus.Text = "STATUS";
            // 
            // infoStatus
            // 
            this.infoStatus.AutoSize = true;
            this.infoStatus.Location = new System.Drawing.Point(32, 103);
            this.infoStatus.MinimumSize = new System.Drawing.Size(220, 13);
            this.infoStatus.Name = "infoStatus";
            this.infoStatus.Size = new System.Drawing.Size(220, 13);
            this.infoStatus.TabIndex = 22;
            this.infoStatus.Text = "System Ready For Update?";
            this.infoStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(158, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Update WWIV";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "Launch WWIV";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(110, 189);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(162, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "Launch WWIV with Network";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // versionNumber
            // 
            this.versionNumber.AutoSize = true;
            this.versionNumber.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionNumber.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.versionNumber.Location = new System.Drawing.Point(138, 244);
            this.versionNumber.Name = "versionNumber";
            this.versionNumber.Size = new System.Drawing.Size(142, 13);
            this.versionNumber.TabIndex = 27;
            this.versionNumber.Text = "WWIV UPDATE V2.0.32 | ßeta";
            // 
            // spinStatus
            // 
            this.spinStatus.Image = global::windows_wwiv_update.Properties.Resources.Ajax_loader;
            this.spinStatus.Location = new System.Drawing.Point(120, 154);
            this.spinStatus.Name = "spinStatus";
            this.spinStatus.Size = new System.Drawing.Size(32, 32);
            this.spinStatus.TabIndex = 28;
            this.spinStatus.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::windows_wwiv_update.Properties.Resources.wwiv;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(51, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 65);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 220);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 23);
            this.button5.TabIndex = 29;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // updateComplete
            // 
            this.updateComplete.AutoSize = true;
            this.updateComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateComplete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.updateComplete.Location = new System.Drawing.Point(32, 163);
            this.updateComplete.MinimumSize = new System.Drawing.Size(220, 13);
            this.updateComplete.Name = "updateComplete";
            this.updateComplete.Size = new System.Drawing.Size(220, 13);
            this.updateComplete.TabIndex = 30;
            this.updateComplete.Text = "Update Complete";
            this.updateComplete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.spinStatus);
            this.Controls.Add(this.versionNumber);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.infoStatus);
            this.Controls.Add(this.netStatus);
            this.Controls.Add(this.telnetStatus);
            this.Controls.Add(this.wwivStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateComplete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Updating WWIV 5";
            ((System.ComponentModel.ISupportInitialize)(this.spinStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label wwivStatus;
        private System.Windows.Forms.Label telnetStatus;
        private System.Windows.Forms.Label netStatus;
        private System.Windows.Forms.Label infoStatus;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label versionNumber;
        private System.Windows.Forms.PictureBox spinStatus;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label updateComplete;
    }
}