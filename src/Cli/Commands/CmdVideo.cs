using McMaster.Extensions.CommandLineUtils;

namespace Cli.Commands
{
    [Command("video", Description = "Youtube video tools"), Subcommand(typeof(CmdVideoDownload))]
    internal class CmdVideo
    {
        public void OnExecute(IConsole console)
        {
            console.WriteLine("Youtube video tools");
        }
    }
}
