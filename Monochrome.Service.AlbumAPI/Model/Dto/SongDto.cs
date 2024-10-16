using System.ComponentModel.DataAnnotations;

namespace Monochrome.Service.AlbumAPI.Model.Dto
{
    public class SongDto
    {
        public Guid SongId { get; set; }
        public required byte[] SongData { get; set; }
        public required string Title { get; set; }
        public Guid MetadataId { get; set; }
        public required SongMetadata Metadata { get; set; }
    }
}
