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
        internal void Add()
        {
            var member = new Member();
             _memberAdministerView.Administer(member);

             _memberRepository.Add(member);
        }
        internal void Update(Member member)
        {
            var originalMember = (Member)member.Clone();
            _memberAdministerView.Administer(member);

            _memberRepository.Update(originalMember, member);
        }
        internal void Delete(Member member)
        {
            _memberRepository.Delete(member);
        }
    }
}
