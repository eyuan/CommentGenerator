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
            this.msTools = new System.Windows.Forms.MenuStrip();
            this.tsmiTools = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChsComment = new System.Windows.Forms.ToolStripMenuItem();
            this.msTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // msTools
            // 
            this.msTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTools});
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
            this.tsmiTools.Size = new System.Drawing.Size(44, 21);
            this.tsmiTools.Text = "工具";
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
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.msTools);
            this.MainMenuStrip = this.msTools;
            this.Name = "fmMain";
            this.Text = "Lims实用小工具";
            this.Activated += new System.EventHandler(this.fmMain_Activated);
            this.Deactivate += new System.EventHandler(this.fmMain_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmMain_FormClosing);
            this.msTools.ResumeLayout(false);
            this.msTools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msTools;
        private System.Windows.Forms.ToolStripMenuItem tsmiTools;
        private System.Windows.Forms.ToolStripMenuItem tsmiChsComment;
    }
}