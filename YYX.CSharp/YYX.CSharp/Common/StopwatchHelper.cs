using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace YYX.CSharp
{
    /// <summary>
    ///统计程序执行时间
    /// 2016-4-14 23:23:08
    /// 尹永贤
    /// yinyongxian@qq.com
    /// </summary>
    public static class StopwatchHelper
    {
        private static Stopwatch stopwatch = new Stopwatch();
        private static TimeSpan timeSpan = new TimeSpan();
        private static TimeSpan previousTimeSpan = new TimeSpan();
        private static string result = string.Empty;

        public static bool IsRunning {
            get
            {
                return stopwatch.IsRunning;
            }
        }
        /// <summary>
        /// 获取时间间隔
        /// </summary>
        public static TimeSpan Elapsed
        {
            get
            {
                return timeSpan;
            }
        }

        public static void Start()
        {
            result = String.Format("时间\t\t总时间间隔\t时间间隔{0}", Environment.NewLine);
            stopwatch.Start();
        }

        public static void Reset()
        {
            stopwatch.Stop();
            result = string.Empty;
            stopwatch.Start();
        }


        public static void Stop()
        {
            AddResult(stopwatch.Elapsed.ToString(), (stopwatch.Elapsed - previousTimeSpan).ToString());

            stopwatch.Stop();
            ShowResult();
        }

        public static void Lap()
        {
            previousTimeSpan = stopwatch.Elapsed;
            AddResult(stopwatch.Elapsed.ToString(), (stopwatch.Elapsed - previousTimeSpan).ToString());
        }

        public static void ShowResult()
        {
            if (stopwatch.IsRunning)
            {
                result += "";
            }
            MessageBox.Show(result, "结果");
        }

        private static void AddResult(string totalTimeSpan, string timeSpan)
        {
            result += String.Format("{0}\t{1}\t{2}{3}", DateTime.Now.ToString(),totalTimeSpan, timeSpan, Environment.NewLine);
        }
    }
}