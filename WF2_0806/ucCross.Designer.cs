namespace WF2_0806
{
    partial class UcCross
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbWheel = new System.Windows.Forms.Label();
            this.tbWheel = new System.Windows.Forms.TextBox();
            this.tbSpeedCount = new System.Windows.Forms.TextBox();
            this.lbSpeedCount = new System.Windows.Forms.Label();
            this.lbColor = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbWheel
            // 
            this.lbWheel.AutoSize = true;
            this.lbWheel.Location = new System.Drawing.Point(49, 37);
            this.lbWheel.Name = "lbWheel";
            this.lbWheel.Size = new System.Drawing.Size(38, 13);
            this.lbWheel.TabIndex = 0;
            this.lbWheel.Text = "Wheel";
            // 
            // tbWheel
            // 
            this.tbWheel.Location = new System.Drawing.Point(93, 34);
            this.tbWheel.Name = "tbWheel";
            this.tbWheel.Size = new System.Drawing.Size(134, 20);
            this.tbWheel.TabIndex = 1;
            // 
            // tbSpeedCount
            // 
            this.tbSpeedCount.Location = new System.Drawing.Point(127, 70);
            this.tbSpeedCount.Name = "tbSpeedCount";
            this.tbSpeedCount.Size = new System.Drawing.Size(100, 20);
            this.tbSpeedCount.TabIndex = 3;
            // 
            // lbSpeedCount
            // 
            this.lbSpeedCount.AutoSize = true;
            this.lbSpeedCount.Location = new System.Drawing.Point(49, 73);
            this.lbSpeedCount.Name = "lbSpeedCount";
            this.lbSpeedCount.Size = new System.Drawing.Size(69, 13);
            this.lbSpeedCount.TabIndex = 2;
            this.lbSpeedCount.Text = "Speed Count";
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Location = new System.Drawing.Point(49, 109);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(31, 13);
            this.lbColor.TabIndex = 4;
            this.lbColor.Text = "Color";
            // 
            // cbColor
            // 
            this.cbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(117, 106);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(110, 21);
            this.cbColor.TabIndex = 6;
            // 
            // ucCross
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.tbSpeedCount);
            this.Controls.Add(this.lbSpeedCount);
            this.Controls.Add(this.tbWheel);
            this.Controls.Add(this.lbWheel);
            this.Name = "ucCross";
            this.Size = new System.Drawing.Size(293, 190);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWheel;
        private System.Windows.Forms.TextBox tbWheel;
        private System.Windows.Forms.TextBox tbSpeedCount;
        private System.Windows.Forms.Label lbSpeedCount;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.ComboBox cbColor;
    }
}
