using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop2.model;
using workshop2.model.Repositories;
using workshop2.view;

namespace workshop2.controller
{
    class BoatAdministerController
    {
        private MemberRepository _memberRepository;
        private BoatAdministerView _boatAdministerView;
        public BoatAdministerController(BoatAdministerView boatAdministerView, MemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
            _boatAdministerView = boatAdministerView;
        }
        internal void Add(Member member)
        {
            Boat boat = new Boat();
            var oldMember = (Member)member.Clone();
            var newBoat = _boatAdministerView.Administer(boat);

            member.Boats.Add(newBoat);
            _memberRepository.Update(oldMember,member);
        }
        internal void Update(Member member,Boat boat)
        {
        
        }
        internal void Delete(Member member, Boat boat)
        {
        }
    }
    
}
