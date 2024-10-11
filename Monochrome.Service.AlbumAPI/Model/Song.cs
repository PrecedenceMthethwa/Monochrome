namespace Monochrome.Service.AlbumAPI.Model
{
    public class Song
    {
        public int SongId { get; set; }
        public required byte[] SongData { get; set; }
        public int MetadataId { get; set; } 
        public required SongMetadata Metadata { get; set; }
    }

}
