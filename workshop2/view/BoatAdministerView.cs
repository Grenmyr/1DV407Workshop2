using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop2.model;

namespace workshop2.view
{
    class BoatAdministerView
    {
        private BoatView _boatView;
        public BoatAdministerView(BoatView boatView) 
        {
            _boatView = boatView;
        }
        internal Boat Administer(Boat boat)
        {
            {
                Console.WriteLine("Enter boat type:");
                boat.Type = _boatView.ChooseType();

                Console.WriteLine("Enter boat length:  [{0}]", boat.Length);
                do
                {
                    string input = Console.ReadLine();
                    if (input == String.Empty)
                    {
                        input = boat.Length.ToString();
                    }
                    try
                    {
                        boat.Length = double.Parse(input);
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Please fill in valid boat length.");
                    }
                } while (true);
                return boat;
            }
        }
    }
}
