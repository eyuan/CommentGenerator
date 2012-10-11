using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lims.Tools
{
    public partial class fmChsComment : Form
    {
        public fmChsComment()
        {
            InitializeComponent();
        }

        private void txtComment_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if(e.KeyChar=Keys.Enter)
            //{
            //    string strComment = txtComment.Text;
            //    //复制到剪切板

            //    //寻找上一窗口，并发送

            //    //关闭该窗体
            //    this.Close();
            //}                        
        }

        private void txtComment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string strComment = txtComment.Text;
                //复制到剪切板
                Clipboard.Clear();
                Clipboard.SetText(strComment);
                //Clipboard.SetText(strComment, TextDataFormat.Text);
                //Clipboard.SetData("{0}",strComment);
                //寻找上一窗口，并发送

                //关闭该窗体
                this.Close();
            }
        }
    }
}
