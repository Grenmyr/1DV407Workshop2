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
    class MemberAdministerController
    {
        private MemberAdministerView _memberAdministerView;
        private MemberRepository _memberRepository;
        public MemberAdministerController(MemberAdministerView memberAdministerView, MemberRepository memberRepository)
        {
            _memberAdministerView = memberAdministerView;
            _memberRepository = memberRepository;
        }
        internal void Run(Member member = null)
        {
            bool creating = false;
            if (member == null)
            {
                creating = true;
                member = new Member();
            }
            var oldMember = (Member)member.Clone();
             _memberAdministerView.Administer(member);

            if (creating)
            {
                _memberRepository.Add(member);
            }
            else 
            {
                _memberRepository.Update(oldMember,member);
            }
        }
        internal void Delete(Member member)
        {
            _memberRepository.Delete(member);
        }
    }
}
