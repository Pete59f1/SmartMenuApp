using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartMenuLibrary;

namespace SmartMenuApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
        }

        private void Run()
        {
            SmartMenu menu = new SmartMenu();
            menu.LoadMenu(System.IO.Path.GetFullPath(@"..\..\..\..\SmartMenuLibrary\SmartMenuLibrary\MenuSpec.txt"));
            menu.Activate();
        }
    }
}
