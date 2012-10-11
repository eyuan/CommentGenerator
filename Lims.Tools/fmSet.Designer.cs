namespace Lims.Tools
{
    partial class fmSet
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbHotKey = new System.Windows.Forms.GroupBox();
            this.txtNormalTextHotKey = new System.Windows.Forms.TextBox();
            this.txtSSHotKey = new System.Windows.Forms.TextBox();
            this.txtCSHotKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbFont = new System.Windows.Forms.GroupBox();
            this.gbHotKey.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ClientScript注释";
            // 
            // gbHotKey
            // 
            this.gbHotKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbHotKey.Controls.Add(this.txtNormalTextHotKey);
            this.gbHotKey.Controls.Add(this.txtSSHotKey);
            this.gbHotKey.Controls.Add(this.txtCSHotKey);
            this.gbHotKey.Controls.Add(this.label3);
            this.gbHotKey.Controls.Add(this.label2);
            this.gbHotKey.Controls.Add(this.label1);
            this.gbHotKey.Location = new System.Drawing.Point(12, 12);
            this.gbHotKey.Name = "gbHotKey";
            this.gbHotKey.Size = new System.Drawing.Size(410, 116);
            this.gbHotKey.TabIndex = 1;
            this.gbHotKey.TabStop = false;
            this.gbHotKey.Text = "快捷键设置";
            // 
            // txtNormalTextHotKey
            // 
            this.txtNormalTextHotKey.Location = new System.Drawing.Point(141, 83);
            this.txtNormalTextHotKey.Name = "txtNormalTextHotKey";
            this.txtNormalTextHotKey.Size = new System.Drawing.Size(258, 21);
            this.txtNormalTextHotKey.TabIndex = 5;
            // 
            // txtSSHotKey
            // 
            this.txtSSHotKey.Location = new System.Drawing.Point(141, 50);
            this.txtSSHotKey.Name = "txtSSHotKey";
            this.txtSSHotKey.Size = new System.Drawing.Size(258, 21);
            this.txtSSHotKey.TabIndex = 4;
            // 
            // txtCSHotKey
            // 
            this.txtCSHotKey.Location = new System.Drawing.Point(141, 20);
            this.txtCSHotKey.Name = "txtCSHotKey";
            this.txtCSHotKey.Size = new System.Drawing.Size(258, 21);
            this.txtCSHotKey.TabIndex = 3;
            this.txtCSHotKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCSHotKey_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "普通文字";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "ServerScript注释";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(347, 262);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbFont
            // 
            this.gbFont.Location = new System.Drawing.Point(12, 134);
            this.gbFont.Name = "gbFont";
            this.gbFont.Size = new System.Drawing.Size(410, 122);
            this.gbFont.TabIndex = 3;
            this.gbFont.TabStop = false;
            this.gbFont.Text = "字体设置";
            // 
            // fmSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 296);
            this.Controls.Add(this.gbFont);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbHotKey);
            this.Name = "fmSet";
            this.Text = "设置";
            this.gbHotKey.ResumeLayout(false);
            this.gbHotKey.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbHotKey;
        private System.Windows.Forms.TextBox txtNormalTextHotKey;
        private System.Windows.Forms.TextBox txtSSHotKey;
        private System.Windows.Forms.TextBox txtCSHotKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbFont;
    }
}