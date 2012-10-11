namespace Lims.Tools
{
    partial class fmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.msTools = new System.Windows.Forms.MenuStrip();
            this.tsmiTools = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChsComment = new System.Windows.Forms.ToolStripMenuItem();
            this.nfTools = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsTools = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSet = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHotKey = new System.Windows.Forms.ToolStripMenuItem();
            this.msTools.SuspendLayout();
            this.cmsTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // msTools
            // 
            this.msTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTools,
            this.设置ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.msTools.Location = new System.Drawing.Point(0, 0);
            this.msTools.Name = "msTools";
            this.msTools.Size = new System.Drawing.Size(284, 25);
            this.msTools.TabIndex = 0;
            this.msTools.Text = "msTools";
            // 
            // tsmiTools
            // 
            this.tsmiTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiChsComment});
            this.tsmiTools.Name = "tsmiTools";
            this.tsmiTools.Size = new System.Drawing.Size(59, 21);
            this.tsmiTools.Text = "工具(&T)";
            // 
            // tsmiChsComment
            // 
            this.tsmiChsComment.Name = "tsmiChsComment";
            this.tsmiChsComment.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.X)));
            this.tsmiChsComment.Size = new System.Drawing.Size(227, 22);
            this.tsmiChsComment.Text = "添加中文注释";
            this.tsmiChsComment.Click += new System.EventHandler(this.tsmiChsComment_Click);
            // 
            // nfTools
            // 
            this.nfTools.ContextMenuStrip = this.cmsTools;
            this.nfTools.Icon = ((System.Drawing.Icon)(resources.GetObject("nfTools.Icon")));
            this.nfTools.Text = "Lims实用小工具";
            this.nfTools.Visible = true;
            this.nfTools.Click += new System.EventHandler(this.nfTools_Click);
            // 
            // cmsTools
            // 
            this.cmsTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSet,
            this.tsmiAbout,
            this.tsmiExit});
            this.cmsTools.Name = "cmsTools";
            this.cmsTools.Size = new System.Drawing.Size(101, 70);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(100, 22);
            this.tsmiAbout.Text = "关于";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(100, 22);
            this.tsmiExit.Text = "退出";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiSet
            // 
            this.tsmiSet.Name = "tsmiSet";
            this.tsmiSet.Size = new System.Drawing.Size(100, 22);
            this.tsmiSet.Text = "设置";
            this.tsmiSet.Click += new System.EventHandler(this.tsmiSet_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHotKey});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.设置ToolStripMenuItem.Text = "设置(&S)";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助ToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.关于ToolStripMenuItem.Text = "关于(&A)";
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // tsmiHotKey
            // 
            this.tsmiHotKey.Name = "tsmiHotKey";
            this.tsmiHotKey.Size = new System.Drawing.Size(152, 22);
            this.tsmiHotKey.Text = "快捷键设置(&K)";
            this.tsmiHotKey.Click += new System.EventHandler(this.tsmiHotKey_Click);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.msTools);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msTools;
            this.Name = "fmMain";
            this.ShowInTaskbar = false;
            this.Text = "Lims实用小工具";
            this.Activated += new System.EventHandler(this.fmMain_Activated);
            this.Deactivate += new System.EventHandler(this.fmMain_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmMain_FormClosing);
            this.Load += new System.EventHandler(this.fmMain_Load);
            this.SizeChanged += new System.EventHandler(this.fmMain_SizeChanged);
            this.msTools.ResumeLayout(false);
            this.msTools.PerformLayout();
            this.cmsTools.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msTools;
        private System.Windows.Forms.ToolStripMenuItem tsmiTools;
        private System.Windows.Forms.ToolStripMenuItem tsmiChsComment;
        private System.Windows.Forms.NotifyIcon nfTools;
        private System.Windows.Forms.ContextMenuStrip cmsTools;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiSet;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiHotKey;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
    }
}