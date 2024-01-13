using Cli.Commands;
using Cli.Services;
using McMaster.Extensions.CommandLineUtils;
using Microsoft.Extensions.DependencyInjection;

namespace Cli
{
    [HelpOption(Inherited = true)]
    [Command(Description = "Youtube download tools"),
    Subcommand(typeof(CmdVideo))]
    internal class Program
    {
        public static string DownloadDir { get; } = "downloads";

        static int Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddSingleton(PhysicalConsole.Singleton);
            serviceCollection.AddSingleton<ICommandService, CommandService>();

            var services = serviceCollection.BuildServiceProvider();

            var app = new CommandLineApplication<Program>();
            app.Conventions.UseDefaultConventions().UseConstructorInjection(services);

            var console = (IConsole)services.GetService(typeof(IConsole));

            try
            {
                return app.Execute(args);
            }
            catch (UnrecognizedCommandParsingException ex)
            {
                console.WriteLine(ex.Message);
                return -1;
            }
        }

        public int OnExecute(CommandLineApplication app, IConsole console)
        {
            console.WriteLine("Please specify a command");
            app.ShowHelp();
            return 1;
        }
    }
}