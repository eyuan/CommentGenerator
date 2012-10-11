using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using Lims.CodeGenerator;

namespace Lims.Tools
{
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();
        }

        private void tsmiChsComment_Click(object sender, EventArgs e)
        {
            Form fmComment = new fmChsComment();
            fmComment.Show();
        }

        #region region 热键操作
        /// <summary>
        /// 注册热键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fmMain_Activated(object sender, EventArgs e)
        {           
            string[] ssKeys = ConfigurationManager.AppSettings.Get("ssHotKey").Split(new char[] {'+'});;
            //普通注释
            HotKey.RegisterHotKey(Handle, 100, HotKey.KeyModifiers.Alt, Keys.S);
            //Client Script 注释
            HotKey.RegisterHotKey(Handle, 101, HotKey.KeyModifiers.Alt, Keys.A);
            //Server Script和Data Source 注释
            HotKey.RegisterHotKey(Handle, 102, HotKey.KeyModifiers.Alt, Keys.D);
            HotKey.RegisterHotKey(Handle, 103, HotKey.KeyModifiers.Alt, Keys.F);


        }
        private string GetKeyNum(string keyName)
        {
            int keyNum=0;
            switch (keyName)
            {
                case "Alt":
                    keyNum = 1;
                    break;
                case "Shift":
                    keyNum = 4;
                    break;
                case "Control":
                    keyNum = 2;
                    break;
            }
            return keyNum.ToString();
        }
        /// <summary>
        /// 注销热键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fmMain_Deactivate(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// 按键响应
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;
            //按快捷键
            switch (m.Msg)
            {
                case WM_HOTKEY:
                    switch (m.WParam.ToInt32())
                    {
                        case 100:   
                            CallChsComment("Normal");
                            break;
                        case 101:
                            CallChsComment("ClientScript");
                            break;
                        case 102: 
                            CallChsComment("ServerScript");
                            break;
                        case 103:
                            CallCodeGenerator();
                            break;
                    }
                    break;
            }
            base.WndProc(ref m);
        }
        #endregion

        private void CallChsComment(string type)
        {
            Form fmComment = new fmChsComment(type);
            fmComment.Show();
            fmComment.TopMost = true;
            fmComment.Focus();
        }
        private void CallCodeGenerator()
        {
            Form fmcodeGenerator = new FmCodeGeneraor();
            fmcodeGenerator.Show();
            fmcodeGenerator.TopMost = true;
        }

        private void fmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            HotKey.UnregisterHotKey(Handle, 100);
            HotKey.UnregisterHotKey(Handle, 101);
            HotKey.UnregisterHotKey(Handle, 102);
            HotKey.UnregisterHotKey(Handle, 103);
        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void fmMain_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.nfTools.Visible = true;
            } 
        }

        private void nfTools_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        #region 托盘图标右键菜单，点击事件       
        /// <summary>
        /// 关于
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            Form fmAbout = new fmAbout();
            fmAbout.Show();
        }
        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiSet_Click(object sender, EventArgs e)
        {
            Form fmSet = new fmSet();
            fmSet.Show();
        }
        #endregion

        private void tsmiHotKey_Click(object sender, EventArgs e)
        {
            Form fmSet = new fmSet();
            fmSet.Show();
        }


    }
}
