using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace YYX.CSharp.Common
{
    /// <summary>
    /// 类保存成配置文件：序列化And反序列化
    /// 尹永贤
    /// 2016-4-3 11:50:01
    /// yinyongxian@qq.com
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public static class ObjectConverter<T>  where T : class, new()
    {

        private static readonly string filePath = Path.Combine(Application.StartupPath, TName + ".bin");
        private static string TName { get { return typeof(T).ToString().Substring(typeof(T).ToString().LastIndexOf('.') + 1); } }

        public static T Load()
        {
            try
            {
                using (Stream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    var formatter = new BinaryFormatter();
                    return (T)formatter.Deserialize(stream);
                }
            }
            catch (FileNotFoundException)
            {
                return new T();
            }
            catch (Exception)
            {
                MessageBox.Show("加载{0}失败。", TName);
                return new T();
            }
        }

        public static void Save(T data)
        {
            try
            {
                using (Stream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    var formatter = new BinaryFormatter();
                    formatter.Serialize(stream, data);
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("保存{0}失败。", TName);
            }
        }
    }
}
