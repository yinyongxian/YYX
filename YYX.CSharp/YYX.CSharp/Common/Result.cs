using System;

namespace YYX.CSharp
{
    /// <summary>
    /// 包含对/错和原因的结果
    /// 尹永贤
    /// 2016-3-21 23:18:55
    /// yinyongxian@qq.com
    /// </summary>
    [Serializable]
    public class Result
    {
        private readonly bool success;
        private readonly string reason;


        public bool Success { get { return success; } }
        public string Reason { get { return reason; } }


        public Result(bool success, string reason)
        {
            this.success = success;
            this.reason = reason;
        }

        public Result(bool success)
            : this(success, string.Empty)
        {

        }

        public Result()
            : this(true)
        {

        }
    }
}

/*多个构造函数相互调用,避免每个构造函数独立初始化数据。*/