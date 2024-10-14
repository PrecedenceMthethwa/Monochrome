using Monochrome.Service.AlbumAPI.Model.Dto;
using System.ComponentModel.DataAnnotations;

namespace Monochrome.Service.AlbumAPI.Model
{
    public class SongMetadata
    {
        [Key]
        public Guid MetadataId { get; set; }
        public required string Artists { get; set; }
        public required string Album { get; set; }
        public  byte[] AlbumCover { get; set; }
        public DateTime Year { get; set; }
        public required string Genre { get; set; }
        public required List<Song> Songs { get; set; }
    }


}
