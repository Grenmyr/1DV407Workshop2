using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop2.model;

namespace workshop2.view
{
    class MemberAdministerView
    {

        internal Member Administer(Member member)
        {
          
            Console.WriteLine("Enter name:  [{0}]", member.Name);
            do
            {
                string input = Console.ReadLine();
                if (input == String.Empty)
                {
                    input = member.Name;
                }

                try
                {
                    member.Name = input;
                    break;
                }
                catch
                {
                    Console.WriteLine("You must fill in a name.");
                }               
            } while (true);
            Console.WriteLine("Enter social security number:  [{0}]", member.SocialSecurityNumber);
            do
            {
                string input = Console.ReadLine();
                if (input == String.Empty)
                {
                    input = member.SocialSecurityNumber;
                }
                try
                {
                    member.SocialSecurityNumber = input;
                    break;
                }
                catch
                {
                    Console.WriteLine("You must fill in a social security number.");
                }
            } while (true);         
            return member;
        }

    }
}
