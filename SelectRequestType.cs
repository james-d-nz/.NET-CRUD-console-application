using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDConsoleApp
{
    class SelectRequestType
    {
        private ConsoleTextInput readInput = new ConsoleTextInput();
        private readonly DatabaseRequests sendRequest = new DatabaseRequests();
        private Utilities utility = new Utilities();

        public void FindSelectedRequestMethod(string requestedInput)
        {
            switch (requestedInput)
            {
                case "Display":
                    Display();
                    break;
                case "Create":
                    Create();
                    break;
                case "Edit":
                    Edit();
                    break;
                case "Delete":
                    Delete();
                    break;
                default:
                    utility.Message("No request type found");
                    break;
            }
        }

        public async void Display()
        {
            utility.Message("You selected Display");
            var fetchArtistNames = await sendRequest.FetchArtistNames();

            foreach (var artist in fetchArtistNames)
            {
                utility.Message(artist);
            }
        }

        public void Create()
        {
            utility.Message("You selected Create");
            var createArtistTextInput = readInput.ReadInput("Enter new Artist name");
            var createArtist = sendRequest.CreateArtist(createArtistTextInput);
            utility.Message(createArtist.Result);
        }

        public void Edit()
        {
            utility.Message("You selected Edit");
            var editArtistTextInput = readInput.ReadInput("Enter name of Artist to edit.");
            var editArtist = sendRequest.EditArtist(editArtistTextInput);
            utility.Message(editArtist.Result);
        }

        public void Delete()
        {
            utility.Message("You selected Delete");
            var deleteArtistTextInput = readInput.ReadInput("Enter name of Artist to delete");
            var deleteArtist = sendRequest.DeleteArtist(deleteArtistTextInput.ToLower());
            utility.Message(deleteArtist.Result);
        }
    }
}
