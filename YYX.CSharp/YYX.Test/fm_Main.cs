using System;
using System.Windows.Forms;
using YYX.Test.ObjectConverter;
using YYX.Test.Ping;
using YYX.Test.SentEmail;

namespace YYX.Test
{
    public partial class fm_Main : Form
    {
        public fm_Main()
        {
            InitializeComponent();

            Func<string, int> showException = null;
            showException = t =>
            {
                MessageBox.Show(t,"未处理异常");

                return 0;
            };

            Application.ThreadException += (sender, args) =>
            {
                showException(args.Exception.Message);
            };

            AppDomain.CurrentDomain.UnhandledException += (sender, args) =>
            {
                showException(args.ExceptionObject.ToString());
            };
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            var stringTime = DateTime.Now.ToString("yyyyMMddHHmmss");

        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 二进制序列化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_ObjectConverter_Click(object sender, EventArgs e)
        {
            using (Form_ObjectConverter form_ObjectConverter = new Form_ObjectConverter())
            {
                form_ObjectConverter.ShowDialog();
            }
        }

        /// <summary>
        /// 邮件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Email_Click(object sender, EventArgs e)
        {
            using (var sendEmali = new SendEmali())
            {
                sendEmali.ShowDialog();
            }
        }

        private void button_Ping_Click(object sender, EventArgs e)
        {
            try
            {
                var form_Ping = new Form_Ping();
                form_Ping.Show();
            }
            catch (Exception)// ex)
            {
                throw;
            }
        }
    }
}
