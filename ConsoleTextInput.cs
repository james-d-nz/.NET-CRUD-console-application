using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDConsoleApp
{
    class ConsoleTextInput
    {
        private Utilities utility = new Utilities();

        public string ReadInput(string message)
        {
            utility.Message(message);
            var readTextInput = Console.ReadLine();
            return readTextInput;
        }
    }
}
