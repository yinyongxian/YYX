using System.Collections.Generic;

using YYX.CSharp.Serialization;

namespace YYX.CSharp.IO
{
    public static class Storage
    {
        private static readonly Dictionary<string, string> dictionary = new Dictionary<string, string>();

        private static bool SetItem(string key, string item)
        {
            if (string.IsNullOrEmpty(key) ||
                string.IsNullOrEmpty(item))
            {
                return false;
            }
            else
            {
                if (dictionary.ContainsKey(key))
                {
                    dictionary[key] = item;
                }
                else
                {
                    dictionary.Add(key, item);
                }

                return true;
            }
        }

        private static bool SetItem<T>(string key, T item)
        {
            if (string.IsNullOrEmpty(key) ||
                item == null)
            {
                return false;
            }
            else
            {
                var jsonString = JsonHelper.JsonSerializer(item);
                if (dictionary.ContainsKey(key))
                {
                    dictionary[key] = jsonString;
                }
                else
                {
                    dictionary.Add(key, jsonString);
                }

                return true;
            }
        }

        private static bool RemoveItem(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                return false;
            }
            else
            {
                if (dictionary.ContainsKey(key))
                {
                    dictionary.Remove(key);
                }
                else
                {
                    return false;
                }

                return true;
            }
        }

        private static bool TryGetItem(string key, out string item)
        {
            if (string.IsNullOrEmpty(key))
            {
                item = string.Empty;
                return false;
            }
            else
            {
                return dictionary.TryGetValue(key, out item);
            }
        }

        private static bool TryGetItem<T>(string key, out T item)
            where T : class
        {
            if (string.IsNullOrEmpty(key))
            {
                item = null;
                return false;
            }
            else
            {
                string jsonString;
                var found = dictionary.TryGetValue(key, out jsonString);
                if (found)
                {
                    item = JsonHelper.JsonDeserialize<T>(jsonString);
                    return true;
                }
                else
                {
                    item = null;
                    return false;
                }
            }
        }
    }
}
