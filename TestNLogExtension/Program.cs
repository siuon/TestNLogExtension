using NLog.Config;

namespace TestNLogExtension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 使用程式註冊 
            //InitialiseNLogRenderer();
            //InitialiseNLogTarget();

            var logger = NLog.LogManager.GetCurrentClassLogger();

            logger.Info("這是程式 Log 的訊息");
        }

        // 範例是使用 NLog 4.7.9
        // 如果使用 NLog 5 以上，註冊方式會需要調整

        private static void InitialiseNLogTarget()
        {
            ConfigurationItemFactory.Default.Targets.RegisterDefinition("MyTarget", typeof(MyTarget));
        }

        private static void InitialiseNLogRenderer()
        {
            ConfigurationItemFactory.Default.LayoutRenderers.RegisterDefinition("MyLayoutRenderer", typeof(MyLayoutRenderer));
        }
    }
}
