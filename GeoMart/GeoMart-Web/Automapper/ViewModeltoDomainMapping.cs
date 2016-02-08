using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using GlobalMartWeb.VMModels;
using GlobalMart_Domain.Entities;

namespace GlobalMartWeb.Automapper
{
    public class ViewModeltoDomainMapping : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModeltoDomainMapping"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Client, ClientVM>();
            Mapper.CreateMap<Product, ProductVM>();

        }
    }
}