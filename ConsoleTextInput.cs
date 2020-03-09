using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDConsoleApp
{
    class ConsoleTextInput
    {
        public string ReadInput()
        {
            Console.WriteLine("Please enter an Artist Name");
            var readTextInput = Console.ReadLine();
            return readTextInput;
        }
    }
}
