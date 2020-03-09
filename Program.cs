using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDConsoleApp
{
    class Program
    {
        private SelectRequestType requestType = new SelectRequestType();
        private Utilities utility = new Utilities();

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
            utility.Message("Select a Request Type (Display, Create, Edit and Delete)");
            var requestTypeInput = Console.ReadLine();
            requestType.FindSelectedRequestMethod(requestTypeInput);
        }
    }
}
