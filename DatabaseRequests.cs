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
            var getArtists = await FetchArtistQuery();
            return getArtists;
        }

        public async Task<string> CreateArtist(string artistName)
        {
            var newArtist = new Artist()
            {
                Name = artistName,
                IsActive = true
            };

            db.Artists.Add(newArtist);
            await db.SaveChangesAsync();
            return "Artist Successfully created";
        }

        public async Task<string> EditArtist(string artistName)
        {

            return "Artist Successfully created";
        }

        public async Task<string> DeleteArtist(string artistName)
        {
            var findArtistToDelete = await FetchArtistByName(artistName);

            if (findArtistToDelete == null)
            {
                return "Could not find artist to delete.";
            }

            findArtistToDelete.IsActive = false;
            await db.SaveChangesAsync();
            return "Successfully delete artist.";
        }

        public async Task<List<string>> FetchArtistQuery()
        {
            var fetchArtist = await db.Artists.Where(x => x.IsActive == true).Select(x => x.Name).ToListAsync();
            return fetchArtist;
        }

        public async Task<Artist> FetchArtistByName(string artistName)
        {
            var fetchArtist = await db.Artists.Where(x => x.Name.ToLower() == artistName && x.IsActive == true).FirstOrDefaultAsync();
            return fetchArtist;
        }
    }
}
