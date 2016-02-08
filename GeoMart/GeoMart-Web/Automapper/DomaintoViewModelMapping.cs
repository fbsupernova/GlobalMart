using AutoMapper;
using GlobalMart_Domain.Entities;
using GlobalMartWeb.VMModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GlobalMartWeb.Automapper
{
   public class DomaintoViewModelMapping : Profile
    {
        public override string ProfileName
        {
            get { return "DomaintoViewModelMapping"; }
        }

        protected  override void Configure()
        {
            Mapper.CreateMap<ClientVM, Client>();
            Mapper.CreateMap<ProductVM, Product>();

        }
    }
}