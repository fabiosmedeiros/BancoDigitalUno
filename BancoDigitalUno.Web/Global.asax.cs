using BancoDigitalUno.Domain.Interfaces.Repository;
using BancoDigitalUno.Domain.Interfaces.UoW;
using BancoDigitalUno.Infra.Data.Data.Repository;
using BancoDigitalUno.Infra.Data.Data.UoW;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Unity;
using Unity.Mvc5;

namespace BancoDigitalUno.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
                        
            // Configurando o container Unity.
            IUnityContainer container = new UnityContainer();
            // Registrando componentes para a Injecao de Dependencia. Interface -> Classe concreta.
            container.RegisterType<IPessoaRepository, PessoaRepository>();
            container.RegisterType<IClienteRepository, ClienteRepository>();
            container.RegisterType<IContaRepository, IContaRepository>();
            container.RegisterType<IEnderecoRepository, EnderecoRepository>();
            container.RegisterType<IUnitOfWork, UnitOfWork>();

            // Definindo o Unity como o Dependency Resolver.
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
