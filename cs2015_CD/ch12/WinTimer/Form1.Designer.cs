﻿namespace WinTimer
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(35, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 69);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(157, 164);
            this.btnEnd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(79, 37);
            this.btnEnd.TabIndex = 11;
            this.btnEnd.Text = "結束";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(274, 164);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(79, 37);
            this.btnStop.TabIndex = 12;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(35, 164);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(79, 37);
            this.btnPlay.TabIndex = 10;
            this.btnPlay.Text = "播放";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 234);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

