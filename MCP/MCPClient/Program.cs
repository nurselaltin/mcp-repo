using ModelContextProtocol;
using ModelContextProtocol.Client;

var clientTransport = new StdioClientTransport(new StdioClientTransportOptions
{
  Name = "MCP SERVER",
  Command = "C:\\Users\\nursel.altin\\source\\repos\\mcp-repo\\MCP\\MCPServer\\bin\\Debug\\net7.0\\MCP.Server.exe"
});

var client = await McpClientFactory.CreateAsync(clientTransport);

//Server Toolsları çek
var tools = await client.ListToolsAsync();
foreach (var tool in tools)
{
  Console.WriteLine(tool);
}