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
        private SelectRequestType requestType = new SelectRequestType();

        static void Main(string[] args)
        {
            Program runProgram = new Program();
            while (true)
            {
                runProgram.runApplication();
            }
        }

        public void runApplication()
        {
            Console.WriteLine("Select a Request Type (Display, Create, Edit and Delete)");
            var requestTypeInput = Console.ReadLine();
            requestType.FindSelectedRequestMethod(requestTypeInput);
        }
    }
}
