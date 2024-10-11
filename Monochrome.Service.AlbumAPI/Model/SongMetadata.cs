namespace Monochrome.Service.AlbumAPI.Model
{
    public class SongMetadata
    {
        public Guid SongMetadataId { get; set; }
        public required string Title { get; set; }
        public required string[] Artists { get; set; }
        public required string Album { get; set; }
        public required string Year { get; set; }
        public required string Genre { get; set; }
        public int TrackNumber { get; set; }
    }

}
