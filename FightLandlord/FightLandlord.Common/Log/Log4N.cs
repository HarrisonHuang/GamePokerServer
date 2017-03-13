using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightLandlord.Common
{
    public static class Log4N
    {
        private static Logger Instance;

        static Log4N()
        {
            try
            {
                Instance = LogManager.GetLogger("NLogConsole");
            }
            catch
            {
                throw new Exception("日志配置错误！");
            }
        }
        public static void Log(this CustomException exception, string errMsg = null)
        {
            switch (exception.Level)
            {
                case ExceptionLevel.Debug:
                    exception.Debug();
                    break;
                case ExceptionLevel.Error:
                    exception.Error();
                    break;
                case ExceptionLevel.Fatal:
                    exception.Fatal();
                    break;
                case ExceptionLevel.Info:
                    exception.Info();
                    break;
                case ExceptionLevel.Trace:
                    exception.Trace();
                    break;
                case ExceptionLevel.Warn:
                    exception.Warn();
                    break;
            }
        }
        public static void Error(this Exception exception, string errMsg = null)
        {
            if (!string.IsNullOrEmpty(errMsg))
            {
                Instance.Error(errMsg);
            }
            Instance.Error(exception.ToString());
        }

        public static void Debug(this Exception exception, string errMsg = null)
        {
            if (!string.IsNullOrEmpty(errMsg))
            {
                Instance.Debug(errMsg);
            }
            Instance.Debug(exception.ToString());
        }
        public static void Warn(this Exception exception, string errMsg = null)
        {
            if (!string.IsNullOrEmpty(errMsg))
            {
                Instance.Warn(errMsg);
            }
            Instance.Warn(exception.ToString());
        }
        public static void Trace(this Exception exception, string errMsg = null)
        {
            if (!string.IsNullOrEmpty(errMsg))
            {
                Instance.Trace(errMsg);
            }
            Instance.Trace(exception.ToString());
        }
        public static void Info(this Exception exception, string errMsg = null)
        {
            if (!string.IsNullOrEmpty(errMsg))
            {
                Instance.Info(errMsg);
            }
            Instance.Info(exception.ToString());
        }
        public static void Fatal(this Exception exception, string errMsg = null)
        {
            if (!string.IsNullOrEmpty(errMsg))
            {
                Instance.Fatal(errMsg);
            }
            Instance.Fatal(exception.ToString());
        }

        public static void Info(string msg)
        {
            Instance.Info(msg);
        }
    }
}
