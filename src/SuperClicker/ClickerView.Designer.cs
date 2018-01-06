namespace SuperClicker
{
    partial class ClickerView
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.cbxPrevent = new System.Windows.Forms.CheckBox();
            this.lblClicksLablel = new System.Windows.Forms.Label();
            this.lblClicks = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.cbxRightClick = new System.Windows.Forms.CheckBox();
            this.pnlClickCount = new System.Windows.Forms.Panel();
            this.numClicksPerSecond = new System.Windows.Forms.NumericUpDown();
            this.lblClicksPerSecond = new System.Windows.Forms.Label();
            this.pnlInfo.SuspendLayout();
            this.pnlClickCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numClicksPerSecond)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(150, 50);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(168, 12);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(150, 50);
            this.btnEnd.TabIndex = 1;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // cbxPrevent
            // 
            this.cbxPrevent.AutoSize = true;
            this.cbxPrevent.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxPrevent.Location = new System.Drawing.Point(3, 3);
            this.cbxPrevent.Name = "cbxPrevent";
            this.cbxPrevent.Size = new System.Drawing.Size(92, 17);
            this.cbxPrevent.TabIndex = 2;
            this.cbxPrevent.Text = "Prevent Cicks";
            this.cbxPrevent.UseVisualStyleBackColor = true;
            this.cbxPrevent.CheckedChanged += new System.EventHandler(this.cbxPrevent_CheckedChanged);
            // 
            // lblClicksLablel
            // 
            this.lblClicksLablel.AutoSize = true;
            this.lblClicksLablel.Location = new System.Drawing.Point(3, 4);
            this.lblClicksLablel.Name = "lblClicksLablel";
            this.lblClicksLablel.Size = new System.Drawing.Size(38, 13);
            this.lblClicksLablel.TabIndex = 3;
            this.lblClicksLablel.Text = "Clicks:";
            this.lblClicksLablel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClicks
            // 
            this.lblClicks.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblClicks.Location = new System.Drawing.Point(47, 4);
            this.lblClicks.Name = "lblClicks";
            this.lblClicks.Size = new System.Drawing.Size(48, 13);
            this.lblClicks.TabIndex = 4;
            this.lblClicks.Text = "0";
            this.lblClicks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.cbxRightClick);
            this.pnlInfo.Controls.Add(this.pnlClickCount);
            this.pnlInfo.Controls.Add(this.cbxPrevent);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInfo.Location = new System.Drawing.Point(0, 86);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(334, 20);
            this.pnlInfo.TabIndex = 5;
            // 
            // cbxRightClick
            // 
            this.cbxRightClick.AutoSize = true;
            this.cbxRightClick.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxRightClick.Location = new System.Drawing.Point(101, 3);
            this.cbxRightClick.Name = "cbxRightClick";
            this.cbxRightClick.Size = new System.Drawing.Size(77, 17);
            this.cbxRightClick.TabIndex = 6;
            this.cbxRightClick.Text = "Right Click";
            this.cbxRightClick.UseVisualStyleBackColor = true;
            // 
            // pnlClickCount
            // 
            this.pnlClickCount.Controls.Add(this.lblClicks);
            this.pnlClickCount.Controls.Add(this.lblClicksLablel);
            this.pnlClickCount.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlClickCount.Location = new System.Drawing.Point(234, 0);
            this.pnlClickCount.Name = "pnlClickCount";
            this.pnlClickCount.Size = new System.Drawing.Size(100, 20);
            this.pnlClickCount.TabIndex = 5;
            // 
            // numClicksPerSecond
            // 
            this.numClicksPerSecond.Location = new System.Drawing.Point(104, 65);
            this.numClicksPerSecond.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numClicksPerSecond.Name = "numClicksPerSecond";
            this.numClicksPerSecond.Size = new System.Drawing.Size(60, 20);
            this.numClicksPerSecond.TabIndex = 6;
            this.numClicksPerSecond.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numClicksPerSecond.ValueChanged += new System.EventHandler(this.numClicksPerSecond_ValueChanged);
            // 
            // lblClicksPerSecond
            // 
            this.lblClicksPerSecond.AutoSize = true;
            this.lblClicksPerSecond.Location = new System.Drawing.Point(4, 67);
            this.lblClicksPerSecond.Name = "lblClicksPerSecond";
            this.lblClicksPerSecond.Size = new System.Drawing.Size(97, 13);
            this.lblClicksPerSecond.TabIndex = 7;
            this.lblClicksPerSecond.Text = "Clicks Per Second:";
            // 
            // ClickerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 106);
            this.Controls.Add(this.lblClicksPerSecond);
            this.Controls.Add(this.numClicksPerSecond);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnStart);
            this.Name = "ClickerView";
            this.Text = "Super Clicker";
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.pnlClickCount.ResumeLayout(false);
            this.pnlClickCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numClicksPerSecond)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.CheckBox cbxPrevent;
        private System.Windows.Forms.Label lblClicksLablel;
        private System.Windows.Forms.Label lblClicks;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Panel pnlClickCount;
        private System.Windows.Forms.CheckBox cbxRightClick;
        private System.Windows.Forms.NumericUpDown numClicksPerSecond;
        private System.Windows.Forms.Label lblClicksPerSecond;
    }
}

