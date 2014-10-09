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
        private BoatAdministerController _boatAdministerController;
        public MemberController(
            MemberView memberView,
            MemberAdministerController memberAdministerController,
            BoatAdministerController boatAdministerController)
        {
            _memberView = memberView;
            _memberAdministerController = memberAdministerController;
            _boatAdministerController = boatAdministerController;
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
                        _memberAdministerController.Delete(member);
                        return;
                    case MemberView.MenuItem.AddBoat:
                        _boatAdministerController.Add(member);
                        return;
                    case MemberView.MenuItem.Return:
                        return;
                    default:
                        throw new NotImplementedException("Menu item not implemented in MemberController.");
                }
            } while (true);
            
        }
    }
}
