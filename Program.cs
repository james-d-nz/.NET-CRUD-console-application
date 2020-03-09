using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDConsoleApp
{
    class Program
    {
        private ConsoleTextInput readInput = new ConsoleTextInput();
        private readonly DatabaseRequests sendRequest = new DatabaseRequests();

        static void Main(string[] args)
        {
            Program runProgram = new Program();
            runProgram.runApplication();
        }

        public void runApplication()
        {
            var textInput = readInput.ReadInput();
            Console.WriteLine("You input" + " " + textInput);
            var dbRequestCreate = sendRequest.createArtist(textInput);
            Console.WriteLine(dbRequestCreate.Result);
            Console.ReadKey();
        }
    }
}
