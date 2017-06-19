using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Xml.Serialization;

namespace YYX.CSharp
{
    /// <summary>
    /// 序列化帮助类
    /// </summary>
    public sealed class SerializeHelper
    {
        #region DataContract序列化
        /// <summary>
        /// DataContract序列化
        /// </summary>
        /// <param name="value"></param>
        /// <param name="knownTypes"></param>
        /// <returns></returns>
        public static string SerializeDataContract(object value, IEnumerable<Type> knownTypes = null)
        {
            var dataContractSerializer = new DataContractSerializer(value.GetType(), knownTypes);

            using (var memoryStream = new MemoryStream())
            {
                dataContractSerializer.WriteObject(memoryStream, value);
                memoryStream.Seek(0, SeekOrigin.Begin);
                using (var streamReader = new StreamReader(memoryStream))
                {
                    return streamReader.ReadToEnd();
                }
            }
        }
        /// <summary>
        /// DataContract反序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xml"></param>
        /// <returns></returns>
        public static T DeserializeDataContract<T>(string xml)
        {
            using (var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(xml)))
            {
                var dataContractSerializer = new DataContractSerializer(typeof(T));
                return (T)dataContractSerializer.ReadObject(memoryStream);
            }
        }
        #endregion

        #region DataContractJson序列化
        /// <summary>
        ///  DataContractJson序列化
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string SerializeDataContractJson(object value)
        {
            var dataContractJsonSerializer = new DataContractJsonSerializer(value.GetType());
            using (var memoryStream = new MemoryStream())
            {
                dataContractJsonSerializer.WriteObject(memoryStream, value);
                return Encoding.UTF8.GetString(memoryStream.ToArray());
            }
        }

        /// <summary>
        /// DataContractJson反序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <returns></returns>
        public static T DeserializeDataContractJson<T>(string json)
        {
            var dataContractJsonSerializer = new DataContractJsonSerializer(typeof(T));
            using (var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(json)))
            {
                return (T)dataContractJsonSerializer.ReadObject(memoryStream);
            }
        }
        #endregion

        #region XmlSerializer序列化
        /// <summary>
        /// 将对象序列化到 XML 文档中和从 XML 文档中反序列化对象。XmlSerializer 使您得以控制如何将对象编码到 XML 中。
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string SerializeXml(object value)
        {
            var xmlSerializer = new XmlSerializer(value.GetType());
            using (var memoryStream = new MemoryStream())
            {
                xmlSerializer.Serialize(memoryStream, value);
                memoryStream.Seek(0, SeekOrigin.Begin);
                using (var streamReader = new StreamReader(memoryStream))
                {
                    return streamReader.ReadToEnd();
                }
            }
        }
        /// <summary>
        ///  XmlSerializer反序列化
        /// </summary>
        /// <param name="type"></param>
        /// <param name="str"></param>
        /// <returns></returns>
        public static object DeserializeXml(Type type, string str)
        {
            var xmlSerializer = new XmlSerializer(type);
            var bytes = Encoding.UTF8.GetBytes(str);
            using (var memoryStream = new MemoryStream(bytes))
            {
                return xmlSerializer.Deserialize(memoryStream);
            }
        }
        #endregion

        #region BinaryFormatter序列化
        /// <summary>
        /// BinaryFormatter序列化
        /// 必须类型必须标记为Serializable
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string SerializeBinaryFormatter(object obj)
        {
            var binaryFormatter = new BinaryFormatter();
            using (var memoryStream = new MemoryStream())
            {
                binaryFormatter.Serialize(memoryStream, obj);
                var bytes = memoryStream.ToArray();
                //如果是UTF8格式，则反序列化报错。可以用Default格式，不过，建议还是传参为byte数组比较好
                return Encoding.Default.GetString(bytes);
            }
        }

        /// <summary>
        /// BinaryFormatter反序列化
        /// 必须类型必须标记为Serializable
        /// </summary>
        /// <param name="serializedStr"></param>
        /// <returns></returns>
        public static T DeserializeBinaryFormatter<T>(string serializedStr)
        {
            var binaryFormatter = new BinaryFormatter();
            var bytes = Encoding.Default.GetBytes(serializedStr);
            using (var memoryStream = new MemoryStream(bytes))
            {
                return (T)binaryFormatter.Deserialize(memoryStream);
            }
        }
        #endregion 

        #region SoapFormatter序列化
        /// <summary>
        /// SoapFormatter序列化
        /// 必须类型必须标记为Serializable
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string SerializeSoapFormatter(object obj)
        {
            var soapFormatter = new SoapFormatter();
            using (var memoryStream = new MemoryStream())
            {
                soapFormatter.Serialize(memoryStream, obj);
                var bytes = memoryStream.ToArray();
                return Encoding.UTF8.GetString(bytes);
            }
        }
        /// <summary>
        /// SoapFormatter反序列化
        /// 必须类型必须标记为Serializable
        /// </summary>
        /// <param name="serializedStr"></param>
        /// <returns></returns>
        public static T DeserializeSoapFormatter<T>(string serializedStr)
        {
            var soapFormatter = new SoapFormatter();
            using (var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(serializedStr)))
            {
                return (T)soapFormatter.Deserialize(memoryStream);
            }
        }
        #endregion
    }
}
