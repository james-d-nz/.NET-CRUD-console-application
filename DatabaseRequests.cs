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
        private ConsoleTextInput readInput = new ConsoleTextInput();

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

            var findArtistToEdit = await FetchArtistByName(artistName);

            if (findArtistToEdit == null)
            {
                return "Could not find artist to edit.";
            }

            var newArtistName = readInput.ReadInput("Enter new name for Artist");
            findArtistToEdit.Name = newArtistName;
            await db.SaveChangesAsync();

            return "Artist Successfully edited";
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
            return "Successfully deleted artist.";
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
