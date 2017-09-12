using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace YYX.CSharp.Serialization
{
    /// <summary>
    /// JSON序列化和反序列化辅助类:DataContract、DataMember
    /// </summary>
    public static class JsonHelper
    {
        /// <summary>
        /// JSON序列化
        /// </summary>
        public static string JsonSerializer<T>(T t)
        {
            var dataContractJsonSerializer = new DataContractJsonSerializer(typeof(T));
            var memoryStream = new MemoryStream();
            dataContractJsonSerializer.WriteObject(memoryStream, t);
            var jsonString = Encoding.UTF8.GetString(memoryStream.ToArray());
            memoryStream.Close();
            return jsonString;
        }

        /// <summary>
        /// JSON反序列化
        /// </summary>
        public static T JsonDeserialize<T>(string jsonString)
        {
            var dataContractJsonSerializer = new DataContractJsonSerializer(typeof(T));
            var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
            var obj = (T)dataContractJsonSerializer.ReadObject(memoryStream);
            return obj;
        }
    }
}
