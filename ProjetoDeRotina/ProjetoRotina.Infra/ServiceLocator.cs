using ProjetoDeRotina.Domain.Interfaces.Repository;
using ProjetoDeRotina.Domain.Service;
using ProjetoDeRotina.Domain.Services;
using ProjetoRotina.Infra.Context;
using RotinaApplication;
using RotinaApplication.Interfaces;
using SimpleInjector;

namespace ProjetoRotina.Infra
{
    public class ServiceLocator
    {
        public static void RegisterServices(Container container)
        {
            container.Register<IJogadorAppService, JogadorAPP>(Lifestyle.Singleton);
            container.Register<IJogadorService, JogadorService>(Lifestyle.Singleton);
            container.Register<IRepositoryBase, RepositoryBase>(Lifestyle.Singleton);
            container.Register<ProjetoRotinaContext>(Lifestyle.Singleton);
        }
    }
}
