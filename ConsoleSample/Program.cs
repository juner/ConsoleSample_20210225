using ConsoleAppFramework;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;

namespace ConsoleSample
{
    class Program : ConsoleAppBase
    {
        static async Task Main(string[] args)
        {
            var Options = new ConsoleAppOptions
            {
                StrictOption = true,
            };
            await CreateDefaultBuilder()
                .RunConsoleAppFrameworkAsync<Program>(args, Options);
        }
        static IHostBuilder CreateDefaultBuilder(string[] args = null)
            => Host.CreateDefaultBuilder(args);
        [Command("build")]
        public void Build(
            [Option(0, "PROJECT")] string project = null, 
            [Option("c", "CONFIGURATION", DefaultValue = "Debug")]string configuration = null,
            [Option("f", "FRAMEWORK")]string framework = null,
            bool force = false,
            bool interactive = false,
            [Command("no-dependencies")]bool no_dependencies = false)
        {
            Console.WriteLine("success");
            Console.WriteLine("project: {0}", project);
            Console.WriteLine("configuration: {0}", configuration);
            Console.WriteLine("framework: {0}", framework);
            Console.WriteLine("force: {0}", force);
            Console.WriteLine("interactive: {0}", interactive);
            Console.WriteLine("no-dependencies: {0}", no_dependencies);
        }
    }
}
