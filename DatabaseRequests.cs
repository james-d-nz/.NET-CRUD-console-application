using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUDConsoleApp.Models;

namespace CRUDConsoleApp
{
    class DatabaseRequests
    {
        private ChinookEntities db = new ChinookEntities();

        public async Task<string> createArtist(string artistName)
        {
            var successMessage = "Artist Successfully created";
            var newArtist = new Artist()
            {
                Name = artistName
            };

            db.Artists.Add(newArtist);
            await db.SaveChangesAsync();
            return successMessage;
        }
    }
}
