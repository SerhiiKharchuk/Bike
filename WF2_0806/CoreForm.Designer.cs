﻿namespace WF2_0806
{
    partial class CoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoreForm));
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.bikeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openSavedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scContainer = new System.Windows.Forms.SplitContainer();
            this.lvBikes = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scContainer)).BeginInit();
            this.scContainer.Panel1.SuspendLayout();
            this.scContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bikeToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.windowsToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(670, 24);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // bikeToolStripMenuItem
            // 
            this.bikeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.toolStripSeparator1,
            this.openSavedToolStripMenuItem});
            this.bikeToolStripMenuItem.Name = "bikeToolStripMenuItem";
            this.bikeToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.bikeToolStripMenuItem.Text = "Bike";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // openSavedToolStripMenuItem
            // 
            this.openSavedToolStripMenuItem.Name = "openSavedToolStripMenuItem";
            this.openSavedToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openSavedToolStripMenuItem.Text = "Open saved";
            this.openSavedToolStripMenuItem.Click += new System.EventHandler(this.openSavedToolStripMenuItem_Click);
            // 
            // scContainer
            // 
            this.scContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scContainer.IsSplitterFixed = true;
            this.scContainer.Location = new System.Drawing.Point(0, 24);
            this.scContainer.Name = "scContainer";
            // 
            // scContainer.Panel1
            // 
            this.scContainer.Panel1.Controls.Add(this.lvBikes);
            this.scContainer.Size = new System.Drawing.Size(670, 343);
            this.scContainer.SplitterDistance = 167;
            this.scContainer.TabIndex = 1;
            // 
            // lvBikes
            // 
            this.lvBikes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colSize});
            this.lvBikes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvBikes.GridLines = true;
            this.lvBikes.Location = new System.Drawing.Point(0, 0);
            this.lvBikes.MultiSelect = false;
            this.lvBikes.Name = "lvBikes";
            this.lvBikes.Size = new System.Drawing.Size(167, 343);
            this.lvBikes.TabIndex = 0;
            this.lvBikes.UseCompatibleStateImageBehavior = false;
            this.lvBikes.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 101;
            // 
            // colSize
            // 
            this.colSize.Text = "Size";
            // 
            // CoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 367);
            this.Controls.Add(this.scContainer);
            this.Controls.Add(this.MainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenuStrip;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(686, 406);
            this.Name = "CoreForm";
            this.Text = "Bike form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CoreForm_FormClosing);
            this.Load += new System.EventHandler(this.CoreForm_Load);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.scContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scContainer)).EndInit();
            this.scContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem bikeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem openSavedToolStripMenuItem;
        private System.Windows.Forms.SplitContainer scContainer;
        private System.Windows.Forms.ListView lvBikes;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colSize;
    }
}

