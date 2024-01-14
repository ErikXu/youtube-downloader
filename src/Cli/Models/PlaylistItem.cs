namespace Cli.Models
{
    internal class PlaylistItem
    {
        public string VideoId { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Length { get; set; }

        public string LengthSeconds { get; set; }

        public string Views { get; set; }

        public bool IsPlayable { get; set; }
    }
}
