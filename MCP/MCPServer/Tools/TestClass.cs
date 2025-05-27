using ModelContextProtocol.Server;
using Serilog;


namespace MCPServer.Tools
{
  [McpServerToolType]
   public static class TestClass
   {
    [McpServerTool]
     public static string SayHi(string msg)
     {
      Log.Information($"Msg: {msg}");
      return "Hi bitch!";
     }
   }
}
