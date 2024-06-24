using NLog;
using NLog.LayoutRenderers;
using System.Text;

namespace TestNLogExtension
{
    [LayoutRenderer("MyLayoutRenderer")]
    public class MyLayoutRenderer : LayoutRenderer
    {
        protected override void Append(StringBuilder builder, LogEventInfo logEvent)
        {
            builder.Append("自訂 layout renderer");
        }
    }
}
