using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GlobalMartWeb.Automapper
{
    public class AutomapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DomaintoViewModelMapping>();
                x.AddProfile<ViewModeltoDomainMapping>();
            }
            );
        }
    }
}