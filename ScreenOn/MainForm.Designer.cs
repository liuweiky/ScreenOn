﻿namespace ScreenOn
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mMonitorCheckBox = new System.Windows.Forms.CheckBox();
            this.mAwakeCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mTimeCounter = new System.Windows.Forms.NumericUpDown();
            this.mStartButton = new System.Windows.Forms.Button();
            this.mStopButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mBackgroundButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mTimeCounter)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mMonitorCheckBox
            // 
            this.mMonitorCheckBox.AutoSize = true;
            this.mMonitorCheckBox.Location = new System.Drawing.Point(6, 22);
            this.mMonitorCheckBox.Name = "mMonitorCheckBox";
            this.mMonitorCheckBox.Size = new System.Drawing.Size(96, 16);
            this.mMonitorCheckBox.TabIndex = 0;
            this.mMonitorCheckBox.Text = "保持屏幕常亮";
            this.mMonitorCheckBox.UseVisualStyleBackColor = true;
            // 
            // mAwakeCheckBox
            // 
            this.mAwakeCheckBox.AutoSize = true;
            this.mAwakeCheckBox.Location = new System.Drawing.Point(6, 58);
            this.mAwakeCheckBox.Name = "mAwakeCheckBox";
            this.mAwakeCheckBox.Size = new System.Drawing.Size(132, 16);
            this.mAwakeCheckBox.TabIndex = 1;
            this.mAwakeCheckBox.Text = "禁止休眠/睡眠/待机";
            this.mAwakeCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "定时(分):";
            // 
            // mTimeCounter
            // 
            this.mTimeCounter.Location = new System.Drawing.Point(68, 88);
            this.mTimeCounter.Maximum = new decimal(new int[] {
            21600,
            0,
            0,
            0});
            this.mTimeCounter.Name = "mTimeCounter";
            this.mTimeCounter.Size = new System.Drawing.Size(67, 21);
            this.mTimeCounter.TabIndex = 4;
            // 
            // mStartButton
            // 
            this.mStartButton.Location = new System.Drawing.Point(175, 34);
            this.mStartButton.Name = "mStartButton";
            this.mStartButton.Size = new System.Drawing.Size(75, 23);
            this.mStartButton.TabIndex = 5;
            this.mStartButton.Text = "开始";
            this.mStartButton.UseVisualStyleBackColor = true;
            this.mStartButton.Click += new System.EventHandler(this.MStartButton_Click);
            // 
            // mStopButton
            // 
            this.mStopButton.Location = new System.Drawing.Point(175, 77);
            this.mStopButton.Name = "mStopButton";
            this.mStopButton.Size = new System.Drawing.Size(75, 23);
            this.mStopButton.TabIndex = 6;
            this.mStopButton.Text = "终止";
            this.mStopButton.UseVisualStyleBackColor = true;
            this.mStopButton.Click += new System.EventHandler(this.MStopButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mMonitorCheckBox);
            this.groupBox1.Controls.Add(this.mAwakeCheckBox);
            this.groupBox1.Controls.Add(this.mTimeCounter);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 143);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(4, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "定时设为0表示一直保持";
            // 
            // mBackgroundButton
            // 
            this.mBackgroundButton.Location = new System.Drawing.Point(175, 120);
            this.mBackgroundButton.Name = "mBackgroundButton";
            this.mBackgroundButton.Size = new System.Drawing.Size(75, 23);
            this.mBackgroundButton.TabIndex = 8;
            this.mBackgroundButton.Text = "后台运行";
            this.mBackgroundButton.UseVisualStyleBackColor = true;
            this.mBackgroundButton.Click += new System.EventHandler(this.MBackgroundButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 167);
            this.Controls.Add(this.mBackgroundButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mStopButton);
            this.Controls.Add(this.mStartButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "ScreenOn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.mTimeCounter)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox mMonitorCheckBox;
        private System.Windows.Forms.CheckBox mAwakeCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown mTimeCounter;
        private System.Windows.Forms.Button mStartButton;
        private System.Windows.Forms.Button mStopButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button mBackgroundButton;
    }
}

