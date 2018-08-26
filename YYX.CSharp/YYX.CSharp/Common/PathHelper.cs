using System;
using System.Windows.Forms;

namespace YYX.CSharp.Common
{
    /// <summary>
    ///文件夹And文件
    /// 尹永贤
    /// 2016-3-21 23:18:55
    /// yinyongxian@qq.com
    /// </summary>
    public static class PathHelper
    {
        /// <summary>
        /// 文件夹任务
        /// </summary>
        /// <param name="action"></param>
        public static void RunWithFloder(Action<string> action)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    action(folderBrowserDialog.SelectedPath);
                }
            }
        }

        /// <summary>
        /// 文件任务
        /// </summary>
        /// <param name="action"></param>
        /// <param name="filter"></param>
        public static void RunWithFile(Action<string> action, string filter)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = filter;
                openFileDialog.Multiselect = false;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    action(openFileDialog.FileName);
                }
            }
        }
    }
}