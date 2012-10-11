namespace Lims.CodeGenerator
{
    partial class FmCodeGeneraor
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtParameter = new System.Windows.Forms.TextBox();
            this.btnGenerateDefault = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxtDefault = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbParameterFrom = new System.Windows.Forms.CheckBox();
            this.cbDefaultTo = new System.Windows.Forms.CheckBox();
            this.btnCopyDefault = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtParameter
            // 
            this.txtParameter.Location = new System.Drawing.Point(75, 17);
            this.txtParameter.Name = "txtParameter";
            this.txtParameter.Size = new System.Drawing.Size(427, 21);
            this.txtParameter.TabIndex = 0;
            // 
            // btnGenerateDefault
            // 
            this.btnGenerateDefault.Location = new System.Drawing.Point(508, 15);
            this.btnGenerateDefault.Name = "btnGenerateDefault";
            this.btnGenerateDefault.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateDefault.TabIndex = 1;
            this.btnGenerateDefault.Text = "生成(&G)";
            this.btnGenerateDefault.UseVisualStyleBackColor = true;
            this.btnGenerateDefault.Click += new System.EventHandler(this.btnGenerateDefault_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "参数列表";
            // 
            // rtxtDefault
            // 
            this.rtxtDefault.Location = new System.Drawing.Point(75, 75);
            this.rtxtDefault.Name = "rtxtDefault";
            this.rtxtDefault.ReadOnly = true;
            this.rtxtDefault.Size = new System.Drawing.Size(508, 168);
            this.rtxtDefault.TabIndex = 3;
            this.rtxtDefault.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "默认值列表";
            // 
            // cbParameterFrom
            // 
            this.cbParameterFrom.AutoSize = true;
            this.cbParameterFrom.Checked = true;
            this.cbParameterFrom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbParameterFrom.Location = new System.Drawing.Point(75, 52);
            this.cbParameterFrom.Name = "cbParameterFrom";
            this.cbParameterFrom.Size = new System.Drawing.Size(144, 16);
            this.cbParameterFrom.TabIndex = 5;
            this.cbParameterFrom.Text = "参数列表来自于剪切板";
            this.cbParameterFrom.UseVisualStyleBackColor = true;
            this.cbParameterFrom.CheckedChanged += new System.EventHandler(this.cbParameterFrom_CheckedChanged);
            // 
            // cbDefaultTo
            // 
            this.cbDefaultTo.AutoSize = true;
            this.cbDefaultTo.Checked = true;
            this.cbDefaultTo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDefaultTo.Location = new System.Drawing.Point(241, 52);
            this.cbDefaultTo.Name = "cbDefaultTo";
            this.cbDefaultTo.Size = new System.Drawing.Size(156, 16);
            this.cbDefaultTo.TabIndex = 6;
            this.cbDefaultTo.Text = "复制默认值列表到剪切板";
            this.cbDefaultTo.UseVisualStyleBackColor = true;
            this.cbDefaultTo.CheckedChanged += new System.EventHandler(this.cbDefaultTo_CheckedChanged);
            // 
            // btnCopyDefault
            // 
            this.btnCopyDefault.Location = new System.Drawing.Point(417, 44);
            this.btnCopyDefault.Name = "btnCopyDefault";
            this.btnCopyDefault.Size = new System.Drawing.Size(85, 23);
            this.btnCopyDefault.TabIndex = 7;
            this.btnCopyDefault.Text = "复制Default";
            this.btnCopyDefault.UseVisualStyleBackColor = true;
            this.btnCopyDefault.Click += new System.EventHandler(this.btnCopyDefault_Click);
            // 
            // FmCodeGeneraor
            // 
            this.AcceptButton = this.btnGenerateDefault;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 250);
            this.Controls.Add(this.btnCopyDefault);
            this.Controls.Add(this.cbDefaultTo);
            this.Controls.Add(this.cbParameterFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtxtDefault);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerateDefault);
            this.Controls.Add(this.txtParameter);
            this.Name = "FmCodeGeneraor";
            this.Text = "代码生成";
            this.Load += new System.EventHandler(this.FmCodeGeneraor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtParameter;
        private System.Windows.Forms.Button btnGenerateDefault;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxtDefault;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbParameterFrom;
        private System.Windows.Forms.CheckBox cbDefaultTo;
        private System.Windows.Forms.Button btnCopyDefault;
    }
}

