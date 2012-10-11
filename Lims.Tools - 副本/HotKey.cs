﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Lims.Tools
{
    class HotKey
    {
        //如果函数执行成功，返回值不为0。
        //如果函数执行失败，返回值为0。
        //要得到扩展错误信息，调用GetLastError。

        [DllImport("user32.dll", SetLastError = true)]
        //静态外部方法
        public static extern bool RegisterHotKey(
            //要定义热键的窗口的句柄
            IntPtr hWnd,                 
            //定义热键ID（不能与其它ID重复）
            int id,    
            //标识热键是否在按Alt、Ctrl、Shift、Windows等键时才会生效
            KeyModifiers fsModifiers,
            //定义热键的内容
            Keys vk                      
            );
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool UnregisterHotKey(
            //要取消热键的窗口的句柄
            IntPtr hWnd,
            //要取消热键的ID
            int id                       
            );



        //定义了“辅助键”的名称（将数字转变为字符以便于记忆，也可去除此枚举而直接使用数值）

        [Flags()]
        public enum KeyModifiers
        {
            None = 0,
            Alt = 1,
            Ctrl = 2,
            Shift = 4,
            WindowsKey = 8
        }
    }
}
