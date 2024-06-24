using NLog;
using NLog.Targets;
using System;

namespace TestNLogExtension
{
    [Target("MyTarget")]
    public sealed class MyTarget : TargetWithLayout
    {
        protected override void Write(LogEventInfo logEvent)
        {
            var logMessage = this.Layout.Render(logEvent);

            write(logMessage);
        }

        private void write(string message)
        {
            Console.WriteLine($"=============");
            Console.WriteLine($"自訂 MyTarget");
            Console.WriteLine($"{message}");
            Console.WriteLine($"=============");
        }
    }
}
