using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDConsoleApp
{
    class Utilities
    {
        public void Message<T>(T messageString)
        {
            Console.WriteLine(messageString);
        }
    }
}
