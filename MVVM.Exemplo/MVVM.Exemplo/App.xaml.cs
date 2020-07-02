using MVVM.Exemplo.Interfaces;
using MVVM.Exemplo.Ioc;
using MVVM.Exemplo.View;
using MVVM.Exemplo.View.Interfaces;
using MVVM.Exemplo.ViewModels;
using MVVM.Exemplo.ViewModels.Interfaces;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM.Exemplo
{
    public partial class App : Application
    {
        public static IAutofac AutofacIoC = new AutofacIoC();

        public App()
        {
            InitializeComponent();

            RegisterType();

            var navigation = AutofacIoC.Resolve<INavigationService>();
            navigation.PushMain<ILoginViewModel, ILoginPage>();
        }

        private static void RegisterType()
        {
            AutofacIoC.RegisterType<LoginPage, ILoginPage>();
            AutofacIoC.RegisterType<LoginViewModel, ILoginViewModel>();
            AutofacIoC.RegisterType<CadastroUsuarioPage, ICadastroUsuarioPage>();
            AutofacIoC.RegisterType<CadastroUsuarioViewModel, ICadastroUsuarioViewModel>();
            AutofacIoC.RegisterType<MainPage, IMainPage>();
            AutofacIoC.RegisterType<MainViewModel, IMainViewModel>();
            AutofacIoC.RegisterType<NavigationService, INavigationService>();
            AutofacIoC.Build();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
