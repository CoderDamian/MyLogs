using MyApplicationLogs.Contracts;
using NLog;

namespace MyApplicationLogs
{
    public class LoggerManager : ILoggerManager
    {
        private static readonly ILogger _logger = LogManager.GetCurrentClassLogger();

        public void LogDebug(string message)
        {
            _logger.Debug(message);
        }

        public void LogError(string message)
        {
            _logger.Error(message, Environment.UserName);
        }

        public void LogError(Exception ex)
        {
            _logger.Error(ex.Message);

            if (ex.InnerException != null)
                _logger.Error(ex.InnerException.ToString(), Environment.UserName);

            if (ex.StackTrace != null)
                _logger.Error(ex.StackTrace, Environment.UserName);
        }

        public void LogInfo(string message)
        {
            _logger.Info(message, Environment.UserName);
        }

        public void LogWarn(string message)
        {
            _logger.Warn(message, Environment.UserName);
        }
    }
}