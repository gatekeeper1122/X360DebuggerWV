﻿namespace X360DebuggerWV
{
    partial class WinModules
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinModules));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showInDumpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showEntryPointInDumpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.showEntryPointInCPUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.Location = new System.Drawing.Point(0, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(642, 300);
            this.listBox1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showInDumpToolStripMenuItem,
            this.showEntryPointInDumpToolStripMenuItem,
            this.showEntryPointInCPUToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(210, 92);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showInDumpToolStripMenuItem
            // 
            this.showInDumpToolStripMenuItem.Name = "showInDumpToolStripMenuItem";
            this.showInDumpToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.showInDumpToolStripMenuItem.Text = "Show Base Address in Dump";
            this.showInDumpToolStripMenuItem.Click += new System.EventHandler(this.showInDumpToolStripMenuItem_Click);
            // 
            // showEntryPointInDumpToolStripMenuItem
            // 
            this.showEntryPointInDumpToolStripMenuItem.Name = "showEntryPointInDumpToolStripMenuItem";
            this.showEntryPointInDumpToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.showEntryPointInDumpToolStripMenuItem.Text = "Show Entry Point in Dump";
            this.showEntryPointInDumpToolStripMenuItem.Click += new System.EventHandler(this.showEntryPointInDumpToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(642, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(49, 22);
            this.toolStripButton1.Text = "Refresh";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // showEntryPointInCPUToolStripMenuItem
            // 
            this.showEntryPointInCPUToolStripMenuItem.Name = "showEntryPointInCPUToolStripMenuItem";
            this.showEntryPointInCPUToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.showEntryPointInCPUToolStripMenuItem.Text = "Show Entry Point in CPU";
            this.showEntryPointInCPUToolStripMenuItem.Click += new System.EventHandler(this.showEntryPointInCPUToolStripMenuItem_Click);
            // 
            // WinModules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 325);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "WinModules";
            this.Text = "Modules";
            this.Load += new System.EventHandler(this.WinModules_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showInDumpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showEntryPointInDumpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showEntryPointInCPUToolStripMenuItem;
    }
}