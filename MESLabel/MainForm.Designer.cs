﻿namespace MESLabel
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.铭牌打印ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.信息配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.铭牌打印ToolStripMenuItem,
            this.信息配置ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1401, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 铭牌打印ToolStripMenuItem
            // 
            this.铭牌打印ToolStripMenuItem.Name = "铭牌打印ToolStripMenuItem";
            this.铭牌打印ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.铭牌打印ToolStripMenuItem.Text = "铭牌打印";
            this.铭牌打印ToolStripMenuItem.Click += new System.EventHandler(this.铭牌打印ToolStripMenuItem_Click);
            // 
            // 信息配置ToolStripMenuItem
            // 
            this.信息配置ToolStripMenuItem.Name = "信息配置ToolStripMenuItem";
            this.信息配置ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.信息配置ToolStripMenuItem.Text = "信息配置";
            this.信息配置ToolStripMenuItem.Click += new System.EventHandler(this.信息配置ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 664);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "铭牌打印";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 铭牌打印ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 信息配置ToolStripMenuItem;
    }
}