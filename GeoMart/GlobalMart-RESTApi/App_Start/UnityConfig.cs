using Microsoft.Practices.Unity;
using Services.Interface;
using Services.Services;
using System.Web.Http;
using Unity.WebApi;

namespace GlobalMart_RESTApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IClientService, ClientService>();
            container.RegisterType<IProductService, ProductService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}