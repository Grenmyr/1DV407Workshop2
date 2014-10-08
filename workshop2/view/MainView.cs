using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop2.view
{
    class MainView
    {
        internal enum MenuItem
        {
            CompactList,
            DetailedList,
            NewMember,
            Quit
        }
        internal void Render()
        {
            Console.WriteLine("BoatClub main menu");
            Console.WriteLine("{0} : Compact list", 1);
            Console.WriteLine("{0} : Detailed list", 2);
            Console.WriteLine("{0} : Add a new member", 3);
            Console.WriteLine("{0} : Quit", "q");
        }

        internal MenuItem GetChosenMenuItem()
        {
            var input = "";
            
            while (true)
            {
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        return MenuItem.CompactList;
                    case "2":
                        return MenuItem.DetailedList;
                    case "3":
                        return MenuItem.NewMember;
                    case "q":
                    case "Q":
                        return MenuItem.Quit;
                    default:
                        Console.WriteLine("The chosen menuitem does not exist.");
                        break;
                }
            }
        }
    }
}
    

