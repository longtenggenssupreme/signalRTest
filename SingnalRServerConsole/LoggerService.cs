using log4net;
using System.Reflection;

namespace SingnalRServer
{
    /// <summary>
    /// 日志服务
    /// </summary>
    public class LoggerService
    {
        #region Fields and Properties
        private static ILog log = null;
        public static ILog Log
        {
            get
            {
                if (log == null)
                {
                    log4net.Config.XmlConfigurator.Configure();
                    log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
                }
                return log;
            }
        }
        private LoggerService()
        {

        }
        #endregion
    }
}
