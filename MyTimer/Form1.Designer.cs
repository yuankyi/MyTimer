namespace MyTimer
{
    partial class Form1
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
            this.btnTimersTimer = new System.Windows.Forms.Button();
            this.lblMainId = new System.Windows.Forms.Label();
            this.btnThreadingTimer = new System.Windows.Forms.Button();
            this.btnFormsTimer = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblSonId = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTimersTimer
            // 
            this.btnTimersTimer.Location = new System.Drawing.Point(49, 43);
            this.btnTimersTimer.Name = "btnTimersTimer";
            this.btnTimersTimer.Size = new System.Drawing.Size(93, 23);
            this.btnTimersTimer.TabIndex = 0;
            this.btnTimersTimer.Text = "TimersTimer";
            this.btnTimersTimer.UseVisualStyleBackColor = true;
            this.btnTimersTimer.Click += new System.EventHandler(this.btnTimersTimer_Click);
            // 
            // lblMainId
            // 
            this.lblMainId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMainId.Location = new System.Drawing.Point(49, 94);
            this.lblMainId.Name = "lblMainId";
            this.lblMainId.Size = new System.Drawing.Size(74, 23);
            this.lblMainId.TabIndex = 1;
            this.lblMainId.Text = "label1";
            this.lblMainId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnThreadingTimer
            // 
            this.btnThreadingTimer.Location = new System.Drawing.Point(174, 43);
            this.btnThreadingTimer.Name = "btnThreadingTimer";
            this.btnThreadingTimer.Size = new System.Drawing.Size(112, 23);
            this.btnThreadingTimer.TabIndex = 2;
            this.btnThreadingTimer.Text = "ThreadingTimer";
            this.btnThreadingTimer.UseVisualStyleBackColor = true;
            this.btnThreadingTimer.Click += new System.EventHandler(this.btnThreadingTimer_Click);
            // 
            // btnFormsTimer
            // 
            this.btnFormsTimer.Location = new System.Drawing.Point(318, 43);
            this.btnFormsTimer.Name = "btnFormsTimer";
            this.btnFormsTimer.Size = new System.Drawing.Size(80, 23);
            this.btnFormsTimer.TabIndex = 3;
            this.btnFormsTimer.Text = "FormsTimer";
            this.btnFormsTimer.UseVisualStyleBackColor = true;
            this.btnFormsTimer.Click += new System.EventHandler(this.btnFormsTimer_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMessage.Location = new System.Drawing.Point(49, 137);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(350, 23);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "label2";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSonId
            // 
            this.lblSonId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSonId.Location = new System.Drawing.Point(129, 94);
            this.lblSonId.Name = "lblSonId";
            this.lblSonId.Size = new System.Drawing.Size(74, 23);
            this.lblSonId.TabIndex = 6;
            this.lblSonId.Text = "label1";
            this.lblSonId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCount
            // 
            this.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCount.Location = new System.Drawing.Point(209, 94);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(74, 23);
            this.lblCount.TabIndex = 8;
            this.lblCount.Text = "label1";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 190);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSonId);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnFormsTimer);
            this.Controls.Add(this.btnThreadingTimer);
            this.Controls.Add(this.lblMainId);
            this.Controls.Add(this.btnTimersTimer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTimersTimer;
        private System.Windows.Forms.Label lblMainId;
        private System.Windows.Forms.Button btnThreadingTimer;
        private System.Windows.Forms.Button btnFormsTimer;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblSonId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCount;
    }
}

