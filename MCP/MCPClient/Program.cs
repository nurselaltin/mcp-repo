using ModelContextProtocol;
using ModelContextProtocol.Client;

var clientTransport = new StdioClientTransport(new StdioClientTransportOptions
{
  Name = "MCP SERVER",
  Command = "PATH"
});

var client = await McpClientFactory.CreateAsync(clientTransport);

//Server Toolsları çek
var tools = await client.ListToolsAsync();
foreach (var tool in tools)
{
  Console.WriteLine(tool);
}