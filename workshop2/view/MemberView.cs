using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop2.model;

namespace workshop2.view
{
    class MemberView
    {
        internal enum MenuItem
        {
            Edit,
            Delete,
            AddBoat,
            Return
        }
        private BoatView _boatView;
        public MemberView(BoatView boatview) 
        {
            _boatView = boatview;
        }
        internal void Render(Member member)
        {
            Console.WriteLine();
            Console.WriteLine("Name: {0}", member.Name);
            Console.WriteLine("Social security number: {0}", member.SocialSecurityNumber);
            Console.WriteLine("Member number: {0}", member.MemberNumber);
      
            foreach (var boat in member.Boats)
            {
                _boatView.Render(boat);
            }
            Console.WriteLine();
            Console.WriteLine("Press E to edit member.");
            Console.WriteLine("Press D to delete member.");
            Console.WriteLine("Press B to add boat.");
            Console.WriteLine("Press R to return.");
        }
        internal MenuItem GetChosenMenuItem()
        {
            var input = "";

            while (true)
            {
                input = Console.ReadLine();
                switch (input)
                {
                    case "e":
                    case "E":
                        return MenuItem.Edit;
                    case "d":
                    case "D":
                        return MenuItem.Delete;
                    case "r":
                    case "R":
                        return MenuItem.Return;
                    case "b":
                    case "B":
                        return MenuItem.AddBoat;
                    default:
                        Console.WriteLine("The chosen menuitem does not exist.");
                        break;
                }
            }
        }
    }
}
