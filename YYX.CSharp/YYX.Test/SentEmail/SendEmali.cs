using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YYX.CSharp.Email;

namespace YYX.Test
{
    public partial class SendEmali : Form
    {
        public SendEmali()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            var emailInfo = new EmailInfo()
            {
                From = /**/"yongxianyin@lusterinc.com",/**//*/"yinyongxian@qq.com",/**/
                To = "yinyongxian@qq.com",
                Subject = "自动发送邮件测试_尹永贤" + DateTime.Now.ToString(),
                Body = "自动发送邮件\n" + DateTime.Now.ToString(),
                Host = /*/"smtp.qq.com",/**//**/"mail.lusterinc.com",/**/
                Password = /*/"1dslhbslfdjx"/**//**/"1dslhbs2fdjX"/**/
            };

            Email.Send(emailInfo);
        }
    }
}
