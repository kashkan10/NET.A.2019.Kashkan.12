namespace BookService.Loggers
{
    /// <summary>
    /// Loggers interface
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Debug level of logs
        /// </summary>
        /// <param name="message"></param>
        void Debug(string message);

        /// <summary>
        /// Info level of logs
        /// </summary>
        /// <param name="message"></param>
        void Info(string message);

        /// <summary>
        /// Warn level of logs
        /// </summary>
        /// <param name="message"></param>
        void Warn(string message);

        /// <summary>
        /// Error level of logs
        /// </summary>
        /// <param name="message"></param>
        void Error(string message);

        /// <summary>
        /// Fatal level of logs
        /// </summary>
        /// <param name="message"></param>
        void Fatal(string message);
    }
}
