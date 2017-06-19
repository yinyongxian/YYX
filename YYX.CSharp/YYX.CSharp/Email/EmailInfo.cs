using System;

namespace YYX.CSharp.Email
{
    [Serializable]
    public class EmailInfo
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Host { get; set; }
        public string Password { get; set; }
        public bool Async { get; set; }

        public EmailInfo()
        {
            From = string.Empty;
            To = string.Empty;
            Subject = string.Empty;
            Body = string.Empty;
            Host = string.Empty;
            Password = string.Empty;
        }

        public EmailInfo(string from, string to, string subject, string body, string host, string password, bool async)
        {
            From = from;
            To = to;
            Subject = subject;
            Body = body;
            Host = host;
            Password = password;
            Async = async;
        }
    }
}