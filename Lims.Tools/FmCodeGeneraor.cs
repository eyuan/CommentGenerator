using System;
using System.Windows.Forms;

namespace Lims.CodeGenerator
{
    public partial class FmCodeGeneraor : Form
    {
        public FmCodeGeneraor()
        {
            InitializeComponent();
        }

        private void btnGenerateDefault_Click(object sender, EventArgs e)
        {
            //:PARAMETERS a,b;
            //:DEFAULT a,"";
            //:DEFAULT b,"";
            string strParas = string.Empty;
            //if(isParameterFromClipboard)
            if(cbParameterFrom.Checked)
            {
                strParas = Clipboard.GetText();
            }
            else
            {
            strParas = txtParameter.Text;
            }
            strParas = strParas.Trim();
            //if (strParas.Length < 11)
            if(!(strParas.StartsWith(":PARAMETERS ")&&(strParas.EndsWith(";"))))
            {
                MessageBox.Show("参数格式输入有误，\n应以:PARAMETERS 开头，以;结尾");
                return;
            }
            strParas = strParas.Substring(11,strParas.Length-12);
            string[] strArrParas = strParas.Split(new char[] {','});
            string strDefaults = string.Empty;
            //foreach(string strPara in strArrParas)
            //{
            //}
            string strPara = string.Empty;
            for (int i = 0; i < strArrParas.Length;i++ )
            {
                strPara = strArrParas[i].Trim();
                strDefaults += ":DEFAULT " + strPara + ", \"\";\n";
            }
            rtxtDefault.Text = strDefaults;
            //if(isDefaultToClipboard)
            if(cbDefaultTo.Checked)
            {
                Clipboard.SetText(strDefaults);
            }
        }

        private void FmCodeGeneraor_Load(object sender, EventArgs e)
        {
            txtParameter.Text = "  :PARAMETERS   a , b; ";
        }

        private bool isParameterFromClipboard = false;
        private bool isDefaultToClipboard = false;
        private void cbParameterFrom_CheckedChanged(object sender, EventArgs e)
        {
            isParameterFromClipboard = cbParameterFrom.Checked;
        }

        private void cbDefaultTo_CheckedChanged(object sender, EventArgs e)
        {
            isDefaultToClipboard = cbDefaultTo.Checked;
        }

        private void btnCopyDefault_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtxtDefault.Text);
        }
    }
}
