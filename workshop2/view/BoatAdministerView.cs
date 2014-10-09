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
        internal Boat Administer(Boat boat)
        {
            {

                Console.WriteLine("Enter type:  [{0}]", boat.Type);
               /* do
                {
                    string input = Console.ReadLine();
                    if (input == String.Empty)
                    {
                        input = boat.Type;
                    }

                    try
                    {
                        boat.Type = input;
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("You must fill in a type.");
                    }
                } while (true);*/
                boat.Type = BoatType.Canoe;
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
                        Console.WriteLine("You must fill in a boat length.");
                    }
                } while (true);
                return boat;
            }
        }
    }
}
