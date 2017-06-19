using System;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;

namespace YYX.Test.Ping
{
    public partial class Form_Ping : Form
    {
        public string IP
        {
            get
            {
                return textBox_IP.Text ?? string.Empty;
            }
        }

        public Form_Ping()
        {
            InitializeComponent();
        }

        private void button_Ping_Click(object sender, EventArgs e)
        {
            button_Ping.Enabled = false;
            var thread = new Thread(() =>
            {
                while (true)
                {
                    var ping = new System.Net.NetworkInformation.Ping();
                    var pingReply = ping.Send(IP);
                    var connected = pingReply.Status == IPStatus.Success;

                    if (connected)
                    {
                        Invoke(new Action(() =>
                        {
                            if (IsHandleCreated)
                            {
                                label_Result.Text = "成功";
                                label_Result.BackColor = Color.Green;
                                button_Ping.Enabled = true;
                            }


                        }));
                    }
                    else
                    {
                        Invoke(new Action(() =>
                        {
                            if (!IsHandleCreated)
                            {
                                label_Result.Text = "失败";
                                label_Result.BackColor = Color.Red;
                            }
                        }));
                    }

                    Thread.Sleep(1000);
                }
            })
            {
                IsBackground = true
            };

            thread.Start();
        }

        private void Form_Ping_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Escape)
            {
                Close();
            }
        }
    }
}