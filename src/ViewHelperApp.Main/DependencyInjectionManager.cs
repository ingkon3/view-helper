using Ninject.Modules;
using ViewHelperApp.Core.Models;

namespace ViewHelperApp.Main;

public class DependencyInjectionManager : NinjectModule
{
    public override void Load()
    {
        Bind<IApplicationDataProperties>().To<ApplicationDataProperties>().InSingletonScope();
    }
}
