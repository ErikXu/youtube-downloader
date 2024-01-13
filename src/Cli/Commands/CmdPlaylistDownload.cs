using HtmlAgilityPack;
using McMaster.Extensions.CommandLineUtils;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cli.Commands
{
    [Command("download", Description = "Download Youtube videos of playlist")]
    internal class CmdPlaylistDownload
    {
        [Required]
        [Option(Description = "Youtube playlist url", ShortName = "u")]
        public string Url { get; set; }

        public void OnExecute(IConsole console)
        {
            var log = new StringBuilder();

            var line = $"Download Youtube videos of playlist of [{Url}]";
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
                var htmlWeb = new HtmlWeb();
                var doc = htmlWeb.LoadFromWebAsync(Url).GetAwaiter().GetResult();
                File.WriteAllText(Path.Combine(dir, "playlist.html"), doc.Text);
            }
            catch (Exception ex)
            {
                log.Append(ex.Message);
                log.AppendLine("Download failed");
            }

            File.WriteAllText(Path.Combine(dir, "log.txt"), log.ToString());

            console.WriteLine($"Youtube video saved in [{dir}]");
        }
    }
}
