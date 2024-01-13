using McMaster.Extensions.CommandLineUtils;

namespace Cli.Commands
{
    [Command("playlist", Description = "Youtube playlist tools"), Subcommand(typeof(CmdPlaylistDownload))]
    internal class CmdPlaylist
    {
        public void OnExecute(IConsole console)
        {
            console.WriteLine("Youtube playlist tools");
        }
    }
}
