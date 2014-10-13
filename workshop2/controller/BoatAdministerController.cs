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
            var originalMember = (Member)member.Clone();
             boat = _boatAdministerView.Administer(boat);

             member.Boats.Add(boat);
            _memberRepository.Update(originalMember,member);
        }
        internal void Update(Member member,Boat boat)
        {
            var originalMember = (Member)member.Clone();
            int boatIndex = member.Boats.IndexOf(boat);
            member.Boats[boatIndex] = _boatAdministerView.Administer(boat);
            _memberRepository.Update(originalMember, member);
        }
        internal void Delete(Member member, Boat boat)
        {
            var originalMember = (Member)member.Clone();
            member.Boats.Remove(boat);
            _memberRepository.Update(originalMember,member);
        }
    }
    
}
