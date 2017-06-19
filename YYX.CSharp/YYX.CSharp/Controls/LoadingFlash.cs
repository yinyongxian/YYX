using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace YYX.CSharp.Controls
{
    /// <summary>
    /// 加载等待提示控件
    /// 尹永贤
    /// 2016-2-22 10:31:13
    /// yinyongxian@qq.com
    /// </summary>
    public static class LoadingFlash
    {
        private static Image flashGif = Properties.Resources.Loading;
        /// <summary>
        /// 显示
        /// </summary>
        public static void Show(Control owner,
            string text, Color foreColor,
            Action beforeAction, Action asyncAction, Action afterAction,
            Image image = null
            )
        {
            if (owner.IsHandleCreated == false)
            {
                throw new InvalidOperationException(string.Format("尝试在类型 {0} 未创建句柄时调用LoadingFlash相关操作", owner.GetType().FullName));
            }

            if (image != null)
            {
                flashGif = image;
            }

            PictureBox pictureBox = null;
            //强制回调父控件线程创建
            owner.Invoke(
                (EventHandler)delegate
                {
                    pictureBox = CreatePictureBox(text, foreColor);
                    //设置pictureBox尺寸
                    {
                        pictureBox.Size = flashGif.Size;
                        var width = owner.Width < flashGif.Size.Width ? owner.Width : flashGif.Size.Width;
                        var height = owner.Height < flashGif.Size.Height ? owner.Height : flashGif.Size.Height;
                        pictureBox.Width = width;
                        pictureBox.Height = height;
                    }

                    pictureBox.Parent = owner;

                    //设置pictureBox位置
                    {
                        var x = (owner.Width - pictureBox.Width) / 2;
                        var y = (owner.Height - pictureBox.Height) / 2;
                        pictureBox.Location = new Point(x, y);
                    }
                });

            //异步执行任务
            ThreadPool.QueueUserWorkItem(
                state =>
                {
                    try
                    {
                        owner.Invoke(
                            (EventHandler)delegate
                            {
                                beforeAction();
                                pictureBox.BringToFront();
                                pictureBox.Show();
                            });

                        asyncAction();

                        owner.Invoke(
                            (EventHandler)delegate
                            {
                                pictureBox.Hide();
                                pictureBox.Dispose(); //释放

                                afterAction();
                            });
                    }
                    catch (Exception ex)
                    {
                        //回调父控件线程抛出异常
                        owner.Invoke((EventHandler)delegate { throw ex; });
                    }
                });
        }

        private static PictureBox CreatePictureBox(string text, Color foreColor)
        {
            var pictureBox =
                new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.AutoSize,
                    Image = flashGif
                };

            pictureBox.Paint +=
                (sender, e) =>
                    TextRenderer.DrawText(
                        e.Graphics,
                        text,
                        pictureBox.Parent.Font,
                        new Rectangle(Point.Empty, pictureBox.Size),
                        foreColor
                        );
            return pictureBox;
        }
    }
}