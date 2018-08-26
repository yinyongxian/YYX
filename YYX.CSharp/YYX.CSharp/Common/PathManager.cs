using System;
using System.Windows.Forms;

namespace YYX.CSharp.Common
{
    public static class PathManager
    {
        /// <summary>
        ///     选择文件夹
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
        ///     选择文件
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