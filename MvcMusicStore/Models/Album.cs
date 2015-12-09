using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcMusicStore.Models
{
    public class Album
    {
        public virtual int AlbumId { get; set; }
        public virtual int GenreId { get; set; } //外键属性
        public virtual int ArtistId { get; set; } //外键属性
        public virtual string Title { get; set; }
        public virtual decimal Price { get; set; }
        public virtual string AlbumArtUrl { get; set; }
        public virtual Genre Genre { get; set; }//导航属性
        public virtual Artist Artist { get; set; } //导航属性
    }
}
