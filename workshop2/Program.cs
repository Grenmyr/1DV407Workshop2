using Autofac;
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
            var builder = new ContainerBuilder();
            builder.RegisterType<MemberListController>();
            builder.RegisterType<MemberListView>();
            builder.RegisterType<BoatView>();
            builder.RegisterType<MemberController>();
            builder.RegisterType<MemberView>();
            builder.RegisterType<BoatView>();
            builder.RegisterType<MemberRepository>();
            builder.RegisterType<MainController>();
            builder.RegisterType<MainView>();
            builder.RegisterType<MemberAdministerView>();
            builder.RegisterType<MemberAdministerController>();

            var injector = builder.Build();
            var mainController = injector.Resolve<MainController>();

            /*var test = new MemberListController(new MemberRepository(), 
                                                new MemberListView(new BoatView()),
                                                new MemberController(new MemberView(new BoatView())));*/
            mainController.Run();
           
        }
    }
}
