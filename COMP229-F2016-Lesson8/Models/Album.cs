namespace COMP229_F2016_Lesson8.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Album
    {
        public int AlbumId { get; set; }

        public int GenreId { get; set; }

        public int ArtistId { get; set; }

        [Required]
        [StringLength(160)]
        public string Title { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Price { get; set; }

        [StringLength(1024)]
        public string AlbumArtUrl { get; set; }

        public virtual Artist Artist { get; set; }

        public virtual Genre Genre { get; set; }
    }
}
