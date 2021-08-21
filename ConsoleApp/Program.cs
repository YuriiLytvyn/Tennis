using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servises;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolService controller = new SchoolService();
            View view = new View(controller);
            view.Menu();
        }
    }
}
