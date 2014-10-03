using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop2.controller;
using workshop2.model;
using workshop2.model.Repositories;
using workshop2.view;

namespace workshop2
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new MemberListController(new MemberRepository(), new MemberListView(new BoatView()));
            test.Run();
            
            /*Console.WriteLine("hej");
            var member = new Member();
            member.Name = "Bosse Batong";
            member.SocialSecurityNumber = "8888888888";
            member.MemberNumber = 1L;
            member.Boats = new List<Boat>();
            member.Boats.Add(new Boat(BoatType.Sailboat, 9));
            
            
            var testMember = new MemberRepository();
            testMember.Add(member);
            foreach (var item in testMember.GetAll())
            {
                //Lista över användare.
                Console.WriteLine(item.MemberNumber);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.SocialSecurityNumber);
            }*/
        }
    }
}
