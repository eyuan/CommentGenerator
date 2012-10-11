using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lims.Tools
{
    public partial class fmSet : Form
    {
        public fmSet()
        {
            InitializeComponent();
        }

        #region 快捷键设置
        /// <summary>
        /// 客户端脚本注释快捷键设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCSHotKey_KeyDown(object sender, KeyEventArgs e)
        {
            //string keys = string.Empty;
            //if (e.Alt)
            //{
            //    keys += "Alt,";
            //}
            //if(e.Control)
            //{
            //    keys += "Control,";
            //}
            //if(e.Shift)
            //{
            //    keys += "Shift,";
            //}
            //keys += e.KeyCode.ToString();
            //MessageBox.Show(keys);
        }

        #endregion

        /// <summary>
        /// 保存设置（插入或更新配置文件信息）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            string strCSHotKey = txtCSHotKey.Text;
            string strSSHotKey = txtSSHotKey.Text;
            string strNoramlTextHotKey = txtNormalTextHotKey.Text;
            //MessageBox.Show(strCSHotKey);
            //Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None); 
            //if(ConfigurationManager.AppSettings.HasKeys())
            //{                
            //}
            //config.AppSettings.Settings.Add("csKey",strCSHotKey);
            //config.AppSettings.Settings.Add("ssKey",strSSHotKey);
            //config.AppSettings.Settings.Add("ntKey",strNoramlTextHotKey);
            //config.Save();

            
                string csKey = ConfigurationManager.AppSettings.Get("csHotKey");
            //MessageBox.Show(csKey);
        }


    }
}
