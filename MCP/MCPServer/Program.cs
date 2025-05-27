using MCPServer.Tools;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;

//Log
Log.Logger = new LoggerConfiguration()
             .MinimumLevel.Verbose() //En ufak detaya kadar logla
             .WriteTo.Console()
             .WriteTo.Debug()
             .CreateLogger();

//Hosting ayarları
var builder = Host.CreateApplicationBuilder(args);

//MCP Metotlar çağır
builder.Services
       .AddMcpServer()
       .WithStdioServerTransport() //I/O üzerinden iletişimi sağlar
       .WithToolsFromAssembly(); // Context toolslar 

await builder.Build().RunAsync();

var tool1 = TestClass.SayHi("Say hi!");
Console.WriteLine(tool1);
Console.ReadLine();

