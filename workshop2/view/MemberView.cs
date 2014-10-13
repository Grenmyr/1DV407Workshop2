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
            EditBoat,
            DeleteBoat,
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
            int count = 0;
            foreach (var boat in member.Boats)
            {
                count++;
                _boatView.Render(boat, String.Format("{0}: ",count));
            }
            Console.WriteLine();
            Console.WriteLine("Press E to edit member.");
            Console.WriteLine("Press D to delete member.");
            Console.WriteLine("Press AB to add boat.");
            Console.WriteLine("Press EB to edit boat");
            Console.WriteLine("Press DB to delete boat");
            Console.WriteLine("Press R to return.");
        }
        internal MenuItem GetChosenMenuItem()
        {
            var input = "";

            while (true)
            {
                input = Console.ReadLine().ToLower();
                switch (input)
                {
                    case "e":
                        return MenuItem.Edit;
                    case "d":
                        return MenuItem.Delete;
                    case "r":
                        return MenuItem.Return;
                    case "ab":
                        return MenuItem.AddBoat;
                    case "eb":
                        return MenuItem.EditBoat;
                    case "db":
                        return MenuItem.DeleteBoat;
                    default:
                        Console.WriteLine("The chosen menuitem does not exist.");
                        break;
                }
            }
        }
        internal Boat GetChosenBoat(List<Boat> boats)
        {

            do
	        {
                Console.WriteLine("Choose what boat to edit.");
                Console.WriteLine("Press R to return");
                var input = Console.ReadLine();           
	           int selected;
               if (input == "r" || input == "R")
               {
                   return null;
               }
               if (int.TryParse(input, out selected) && selected <= boats.Count && selected > 0)
                {
                    return boats[selected-1];
                }
                    Console.WriteLine("You must choose a correct number.");
	        } while (true);       
        }
    }
}
