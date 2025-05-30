using MCPServer.Tools;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

//Hosting ayarları
var builder = Host.CreateApplicationBuilder(args);

//Logging ayarları
builder.Logging
    .ClearProviders()
    .AddConsole()
    .AddDebug()
    .SetMinimumLevel(LogLevel.Trace);

//MCP Metotlar çağır
builder.Services
       .AddMcpServer()
       .WithStdioServerTransport() //I/O üzerinden iletişimi sağlar
       .WithToolsFromAssembly(); // Context toolslar 

await builder.Build().RunAsync();
Console.ReadLine();
//var tool1 = TestClass.SayHi("Say hi!");
//Console.WriteLine(tool1);
//Console.ReadLine();

