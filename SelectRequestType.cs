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
                    Console.WriteLine("Request type not found");
                    break;
            }
        }

        public async void Display()
        {
            Console.WriteLine("You selected Display");
            var fetchArtistNames = await sendRequest.fetchArtistsNames();

            foreach (var artist in fetchArtistNames)
            {
                Console.WriteLine(artist);
            }
        }

        public void Create()
        {
            var artistTextInput = readInput.ReadInput();
            var createArtist = sendRequest.createArtist(artistTextInput);
            Console.WriteLine(createArtist.Result);
        }

        public void Edit()
        {
            Console.WriteLine("You selected Edit");
            Console.ReadKey();
        }

        public void Delete()
        {
            Console.WriteLine("You selected Delete");
            Console.ReadKey();
        }
    }
}
