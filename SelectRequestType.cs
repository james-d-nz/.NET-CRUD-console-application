using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDConsoleApp
{
    class SelectRequestType
    {
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

        public void Display()
        {
            Console.WriteLine("You selected Display");
            Console.ReadKey();
        }

        public void Create()
        {
            Console.WriteLine("You selected Create");
            Console.ReadKey();
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
