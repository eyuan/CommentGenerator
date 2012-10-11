namespace Lims.Tools
{
    partial class fmChsComment
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
            this.rtxtComment = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtxtComment
            // 
            this.rtxtComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtComment.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtxtComment.Location = new System.Drawing.Point(-2, 0);
            this.rtxtComment.Name = "rtxtComment";
            this.rtxtComment.Size = new System.Drawing.Size(604, 264);
            this.rtxtComment.TabIndex = 0;
            this.rtxtComment.Text = "";
            this.rtxtComment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtxtComment_KeyDown);
            // 
            // fmChsComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 262);
            this.Controls.Add(this.rtxtComment);
            this.Name = "fmChsComment";
            this.Text = "添加中文注释";
            this.Load += new System.EventHandler(this.fmChsComment_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtComment;

    }
}