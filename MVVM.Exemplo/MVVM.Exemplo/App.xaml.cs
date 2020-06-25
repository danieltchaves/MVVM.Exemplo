using MVVM.Exemplo.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM.Exemplo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new BindingModePage();
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
