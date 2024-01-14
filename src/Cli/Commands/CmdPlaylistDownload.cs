using Cli.Models;
using HtmlAgilityPack;
using McMaster.Extensions.CommandLineUtils;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cli.Commands
{
    [Command("download", Description = "Download Youtube videos of playlist, eg: ytdl playlist download -u https://www.youtube.com/playlist?list=xxxxxx")]
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

                var scripts = doc.DocumentNode.SelectNodes("//script");

                var script = scripts.First(n => n.InnerHtml.Contains("ytInitialData"));

                var json = script.InnerHtml.Replace("var ytInitialData = ", string.Empty).TrimEnd(';');

                var result = JsonConvert.DeserializeObject<PlaylistResult>(json);

                var playlist = result.contents.twoColumnBrowseResultsRenderer.tabs[0].tabRenderer
                                     .content.sectionListRenderer
                                     .contents[0].itemSectionRenderer
                                     .contents[0].playlistVideoListRenderer
                                     .contents.Select(n => new PlaylistItem
                                     {
                                         VideoId = n.playlistVideoRenderer.videoId,
                                         Title = n.playlistVideoRenderer.title.runs[0].text,
                                         Author = n.playlistVideoRenderer.shortBylineText.runs[0].text,
                                         Length = n.playlistVideoRenderer.lengthText.simpleText,
                                         LengthSeconds = n.playlistVideoRenderer.lengthSeconds,
                                         Views = n.playlistVideoRenderer.videoInfo.runs[0].text,
                                         IsPlayable = n.playlistVideoRenderer.isPlayable
                                     });

                var playlistJson = JsonConvert.SerializeObject(playlist, Formatting.Indented);
                File.WriteAllText(Path.Combine(dir, "playlist.json"), playlistJson);
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
