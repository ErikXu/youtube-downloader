using McMaster.Extensions.CommandLineUtils;

namespace Cli.Commands
{
    [Command("download", Description = "Download Youtube video")]
    internal class CmdVideoDownload
    {
        public void OnExecute(IConsole console)
        {
            console.WriteLine("Download Youtube video");
        }
    }
}
