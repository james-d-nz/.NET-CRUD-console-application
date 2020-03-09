using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using CRUDConsoleApp.Models;

namespace CRUDConsoleApp
{
    class DatabaseRequests
    {
        private ChinookEntities db = new ChinookEntities();

        public async Task<List<string>> FetchArtistNames()
        {
            var getArtists = await db.Artists.Where(x => x.IsActive == true).Select(x => x.Name).ToListAsync();
            return getArtists;
        }

        public async Task<string> CreateArtist(string artistName)
        {
            var newArtist = new Artist()
            {
                Name = artistName
            };

            db.Artists.Add(newArtist);
            await db.SaveChangesAsync();
            return "Artist Successfully created";
        }

        public async Task<string> DeleteArtist(string artistName)
        {
            var findArtistToDelete = db.Artists.Where(x => x.Name.ToLower() == artistName && x.IsActive == true).FirstOrDefaultAsync();

            if (findArtistToDelete.Result == null)
            {
                return "Could not find artist to delete.";
            }

            findArtistToDelete.Result.IsActive = false;
            await db.SaveChangesAsync();
            return "Successfully delete artist.";
        }
    }
}
