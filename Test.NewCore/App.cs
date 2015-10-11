using Cirrious.CrossCore;
using Cirrious.CrossCore.IoC;
using Cirrious.MvvmCross.ViewModels;
using Test.NewCore.ViewModels;

namespace Test.NewCore
{
    public class App : MvxApplication
    {
        public App()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
            
            // Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<TestViewModel>());
            RegisterAppStart<ViewModels.TestViewModel>();
        }
    }
}
