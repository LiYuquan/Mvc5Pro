using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MvcMusicStore.Models
{
    class MusicStoreDbInitializer:DropCreateDatabaseAlways<MusicStoreDB>
    {
        protected override void Seed(MusicStoreDB context)
        {
            context.Artists.Add(new Artist { Name = "周杰伦" });
            context.Genres.Add(new Genre { Name = "流行" });
            context.Albums.Add(new Album
            {
                Artist = new Artist { Name = "Jay" },
                Genre = new Genre { Name = "Classic" },
                Price = 9.99m,
                Title = "哎呦，不错"
            });
            base.Seed(context);
        }
    }
}
