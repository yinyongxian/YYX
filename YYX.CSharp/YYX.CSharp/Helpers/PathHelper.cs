using System.IO;
using System.Windows.Forms;

namespace YYX.CSharp.Helpers
{
    public static class PathHelper
    {
        public static string MapPath(string path)
        {
            return Path.Combine(Application.StartupPath, path);
        }
    }
}