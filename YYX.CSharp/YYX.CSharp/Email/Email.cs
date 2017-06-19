using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Text.RegularExpressions;

namespace YYX.CSharp.Email
{

    /// <summary>  
    /// 邮件
    /// 尹永贤
    /// 2015-10-8 10:03:09
    /// yinyongxian@qq.com
    /// </summary>  
    public class Email
    {
        private MailMessage mailMessage;
        private SmtpClient smtpClient;
        private string password;//发件人密码  

        /**//// <summary>  
        /// Email实例化 
        /// </summary>  
        /// <param name="to">收件人地址</param>  
        /// <param name="from">发件人地址</param>  
        /// <param name="Body">邮件正文</param>  
        /// <param name="Title">邮件的主题</param>  
        /// <param name="Password">发件人密码</param>  
        public Email(string from, string to, string subject, string body, string password)
        {
            mailMessage = new MailMessage(from, to, subject, body);
            mailMessage.BodyEncoding = Encoding.UTF8;
            mailMessage.IsBodyHtml = true;

            this.password = password;
        }

        /**//// <summary>
        /// 添加附件
        /// </summary>
        /// <param name="Path">附件路径，以“，”隔开</param>
        public void Attachments(string Path)
        {
            string[] path = Path.Split(',');
            Attachment data;

            ContentDisposition disposition;
            for (int i = 0; i < path.Length; i++)
            {
                data = new Attachment(path[i], MediaTypeNames.Application.Octet);//实例化附件
                disposition = data.ContentDisposition;
                disposition.CreationDate = System.IO.File.GetCreationTime(path[i]);//获取附件的创建日期
                disposition.ModificationDate = System.IO.File.GetLastWriteTime(path[i]);//获取附件的修改日期
                disposition.ReadDate = System.IO.File.GetLastAccessTime(path[i]);//获取附件的读取日期
                mailMessage.Attachments.Add(data);//添加到附件中  
            }
        }

        /**//// <summary>  
        /// 异步发送邮件  
        /// </summary>  
        /// <param name="CompletedMethod">邮件发送结束时执行的方法</param>  
        public void SendAsync(SendCompletedEventHandler CompletedMethod, string host = "")
        {
            if (mailMessage != null)
            {
                smtpClient = new SmtpClient();
                smtpClient.Credentials = new System.Net.NetworkCredential(mailMessage.From.Address, password);//设置发件人身份的票据  
                smtpClient.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                smtpClient.Host = !string.IsNullOrEmpty(host) ? host
                  : Regex.IsMatch(mailMessage.From.Host, "lusterinc.com") ? "mail." + mailMessage.From.Host
                  : "smtp." + mailMessage.From.Host;

                smtpClient.SendCompleted += new SendCompletedEventHandler(CompletedMethod);//注册异步发送邮件完成时的事件  
                smtpClient.SendAsync(mailMessage, mailMessage.Body);
            }
        }

        /**//// <summary>  
        /// 发送邮件  
        /// </summary>  
        public void Send(string host = "")
        {
            if (mailMessage != null)
            {
                smtpClient = new SmtpClient();
                smtpClient.Credentials = new System.Net.NetworkCredential(mailMessage.From.Address, password);
                smtpClient.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                smtpClient.Host = !string.IsNullOrEmpty(host) ? host
                                  : Regex.IsMatch(mailMessage.From.Host, "lusterinc.com") ? "mail." + mailMessage.From.Host
                                  : "smtp." + mailMessage.From.Host;

                smtpClient.Send(mailMessage);
            }
        }

        public static void Send(EmailInfo emailInfo , SendCompletedEventHandler smtpClient_SendCompleted = null)
        {
            MailMessage message = new MailMessage(emailInfo.From, emailInfo.To, emailInfo.Subject, emailInfo.Body);
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;

            SmtpClient smtpClient = new SmtpClient(emailInfo.Host);
            smtpClient.SendCompleted += smtpClient_SendCompleted;
            smtpClient.Credentials = new System.Net.NetworkCredential(emailInfo.From, emailInfo.Password);
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;

            #region QQ邮箱需开启SSL
            if (message.From.Host.Equals("qq.com"))
            {
                smtpClient.EnableSsl = true;
            } 
            #endregion QQ邮箱需开启SSL

            if (emailInfo.Async)
            {
                smtpClient.SendAsync(message,null);
                return;
            }
            smtpClient.Send(message);
        }/**/
    }
}