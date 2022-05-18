namespace OCP_Follow
{
    public class LogService
    {
        private readonly ILogger Logger;
        public LogService(ILogger logger) => Logger = logger;
        public void Write(Activity activity)
        {
            Logger.Write(activity);
        }
    }
}