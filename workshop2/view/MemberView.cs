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
        private BoatView _boatView;
        public MemberView(BoatView boatview) 
        {
            _boatView = boatview;
        }
        internal void Render(Member member)
        {
            
            Console.WriteLine(member.MemberNumber);
            Console.WriteLine(member.Name);
            Console.WriteLine(member.SocialSecurityNumber);
            foreach (var boat in member.Boats)
            {
                _boatView.Render(boat);
            }
        }
    }
}
