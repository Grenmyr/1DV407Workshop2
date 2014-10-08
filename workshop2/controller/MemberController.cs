using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop2.model;
using workshop2.view;

namespace workshop2.controller
{
    class MemberController
    {
        private MemberView _memberView;
        public MemberController(MemberView memberView)
        {
            _memberView = memberView;
        }

        internal void Run(Member member)
        {
            _memberView.Render(member);
        }
    }
}
