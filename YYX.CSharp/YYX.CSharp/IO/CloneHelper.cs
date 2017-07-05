using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace YYX.CSharp.IO
{
    /// <summary>
    /// 克隆
    /// 尹永贤
    /// yinyongxian@qq.com
    /// 2017-7-5 17:25:44
    /// </summary>
    public static class CloneHelper
    {
        public static T DeepClone<T>(T sourceData)
        {
            try
            {
                CheckNull(sourceData);
                return (T)SerializeAndDeserialize(sourceData);
            }
            catch (Exception ex)
            {
                var message = string.Format("类型‘{0}’深度克隆失败。", typeof(T).FullName);
                throw new InvalidOperationException(message, ex);
            }
        }

        private static object SerializeAndDeserialize(object sourceData)
        {
            using (Stream stream = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, sourceData);

                stream.Seek(0, SeekOrigin.Begin);
                return formatter.Deserialize(stream);
            }
        }

        //====================================================================================================
        //以上是深度克隆
        //----------------------------------------------------------------------------------------------------
        //以下是再次创建同类型实例
        //====================================================================================================

        public static T CreateInstanceAgain<T>(T nowInstance)
        {
            try
            {
                CheckNull(nowInstance);
                return (T)CreateInstance(nowInstance.GetType());
            }
            catch (Exception ex)
            {
                var message = string.Format("类型‘{0}’再次创建实例失败。", typeof(T).FullName);
                throw new InvalidOperationException(message, ex);
            }
        }

        private static object CreateInstance(Type type)
        {
            var Assembly = type.Assembly;
            var typeFullName = type.FullName;
            return Assembly.CreateInstance(typeFullName, true);
        }

        //====================================================================================================
        //以上是再次创建同类型实例
        //----------------------------------------------------------------------------------------------------
        //以下是校验空值
        //====================================================================================================

        private static void CheckNull<T>(T t)
        {
            if (t == null)
            {
                const string message = "传入参数不能为空。";
                throw new InvalidOperationException(message);
            }
        }
    }
}
