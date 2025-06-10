using ModelContextProtocol.Server;
using Microsoft.Extensions.Logging;
using System.ComponentModel;

namespace MCPServer.Tools
{
    [McpServerToolType]
    public static class TestClass
    {
        private static readonly ILogger _logger = LoggerFactory.Create(builder => builder.AddConsole()).CreateLogger("TestClass");

        [McpServerTool, Description("Bu metot say hi diyor.")]
        public static string SayHi(string msg)
        {
            _logger.LogInformation($"Msg: {msg}");
            return "Hi bitch!";
        }
    }
}



