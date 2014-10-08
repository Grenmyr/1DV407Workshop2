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
        private MemberAdministerController _memberAdministerController;
        public MemberController(MemberView memberView, MemberAdministerController memberAdministerController)
        {
            _memberView = memberView;
            _memberAdministerController = memberAdministerController;
        }

        internal void Run(Member member)
        {
            do
            {
                _memberView.Render(member);
                switch (_memberView.GetChosenMenuItem())
                {

                    case MemberView.MenuItem.Edit:
                        _memberAdministerController.Run(member);
                        break;
                    case MemberView.MenuItem.Delete:
                        
                        break;
                    case MemberView.MenuItem.Return:
                        return;
                    default:
                        throw new NotImplementedException("Menu item not implemented in MemberController.");
                }
            } while (true);
            
        }
    }
}
