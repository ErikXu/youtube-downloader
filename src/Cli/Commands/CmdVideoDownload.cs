using Cli.Services;
using McMaster.Extensions.CommandLineUtils;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Text;

namespace Cli.Commands
{
    [Command("download", Description = "Download Youtube video, eg: ytdl video download -u https://www.youtube.com/watch?v=xxxxxx")]
    internal class CmdVideoDownload
    {
        [Required]
        [Option(Description = "Youtube video url", ShortName = "u")]
        public string Url { get; set; }

        public void OnExecute(IConsole console, ICommandService commandService)
        {
            var log = new StringBuilder();

            var line = $"Downloading Youtube video of [{Url}]";
            console.WriteLine(line);
            log.AppendLine(line);

            var taskId = Guid.NewGuid().ToString();

            line = $"Start downloading, task id: [{taskId}]";
            console.WriteLine($"Start downloading, task id: [{taskId}]");
            log.AppendLine(line);

            var dir = Path.Combine(Program.DownloadDir, taskId);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            try
            {
                var isWindows = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);

                var command = $"./yt-dlp_linux --paths {dir} {Url}";

                if (isWindows)
                {
                    command = $"./yt-dlp --paths {dir} {Url}";
                }

                var (code, message) = commandService.ExecuteCommand(command);
                log.Append(message);

                if (code != 0)
                {
                    log.AppendLine("Download failed");
                }
                else
                {
                    log.AppendLine("Download success");
                }
            }
            catch (Exception ex)
            {
                console.WriteLine(ex.Message);
                console.WriteLine(ex.StackTrace);
                console.WriteLine("Download failed");

                log.AppendLine(ex.Message);
                log.AppendLine(ex.StackTrace);
                log.AppendLine("Download failed");
            }

            File.WriteAllText(Path.Combine(dir, "log.txt"), log.ToString());
           
            console.WriteLine($"Youtube video saved in [{dir}]");
        }
    }
}
