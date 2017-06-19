using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace YYX.CSharp
{
    /// <summary>  
    /// xml序列化和反序列化  
    /// 尹永贤  
    /// 2015-11-4 16:26:04  
    /// yinyongxian@qq.com  
    /// </summary>  
    /// <typeparam name="T"></typeparam>  
    public static class XmlSerializerHelper<T> where T : class, new()
    {
        private static readonly string filePath = Path.Combine(Application.StartupPath, T_Name + ".xml");
        private static string T_Name { get { return typeof(T).ToString().Substring(typeof(T).ToString().LastIndexOf('.') + 1); } }
        /// <summary>  
        /// xml反序列化类  
        /// </summary>  
        /// <param name="t">反序列化实例</param>  
        public static T Load()
        {
            try
            {
                T t;
                using (var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    var xmlSerializer = new XmlSerializer(typeof(T));
                    t = xmlSerializer.Deserialize(fileStream) as T;
                }
                return t;
            }
            catch (FileNotFoundException)
            {
                return new T();
            }
            catch (Exception)
            {
                MessageBox.Show("加载{0}失败。", T_Name);
                return new T();
            }
        }

        /// <summary>  
        /// xml序列化类  
        /// </summary>  
        /// <param name="t"></param>  
        public static void Save(T t)
        {
            try
            {
                using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    var xmlSerializer = new XmlSerializer(typeof(T));
                    xmlSerializer.Serialize(fileStream, t);
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("保存{0}失败。", T_Name);
            }
        }
    }
}
