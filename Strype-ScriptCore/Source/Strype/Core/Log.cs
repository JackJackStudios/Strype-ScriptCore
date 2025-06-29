namespace Strype
{
    public static class Log
    {
        internal enum LogLevel
        {
            Trace = 1 << 0,
            Info = 1 << 2,
            Warn = 1 << 3,
            Error = 1 << 4,
        }

        internal static string Format(string format, object[] parameters) => string.Format(format, parameters);
        internal static string Format(object value) => value != null ? value.ToString() : "null";

        public static void Trace(string format, params object[] parameters)
        {
            unsafe { InternalCalls.Log_LogMessage(LogLevel.Trace, Format(format, parameters)); }
        }

        public static void Info(string format, params object[] parameters)
        {
            unsafe { InternalCalls.Log_LogMessage(LogLevel.Info, Format(format, parameters)); }
        }

        public static void Warn(string format, params object[] parameters)
        {
            unsafe { InternalCalls.Log_LogMessage(LogLevel.Warn, Format(format, parameters)); }
        }

        public static void Error(string format, params object[] parameters)
        {
            unsafe { InternalCalls.Log_LogMessage(LogLevel.Error, Format(format, parameters)); }
        }

        public static void Trace(object value)
        {
            unsafe { InternalCalls.Log_LogMessage(LogLevel.Trace, Format(value)); }
        }

        public static void Info(object value)
        {
            unsafe { InternalCalls.Log_LogMessage(LogLevel.Info, Format(value)); }
        }

        public static void Warn(object value)
        {
            unsafe { InternalCalls.Log_LogMessage(LogLevel.Warn, Format(value)); }
        }

        public static void Error(object value)
        {
            unsafe { InternalCalls.Log_LogMessage(LogLevel.Error, Format(value)); }
        }

    }
}