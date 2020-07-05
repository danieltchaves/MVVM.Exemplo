using System.Threading.Tasks;
using Xamarin.Forms;

namespace MVVM.Exemplo.ViewModels
{
    public class Navigation : Exemplo.Interfaces.INavigationService
    {
        public void PushMain<IViewModel, IView>()
        {
            Application.Current.MainPage = new NavigationPage(GetPage<IViewModel, IView>());
        }

        public Task PushAsync<IViewModel, IView>()
        {
            return Application.Current.MainPage.Navigation.PushAsync(GetPage<IViewModel, IView>());
        }

        public async Task PopAsync()
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }

        public async Task PopToRootAsync()
        {
            await Application.Current.MainPage.Navigation.PopToRootAsync();
        }

        public Page GetPage<IViewModel, IView>()
        {
            var view = App.AutofacIoC.Resolve<IView>() as Page;
            var viewModel = App.AutofacIoC.Resolve<IViewModel>();
            view.BindingContext = viewModel;
            return view;
        }
    }
}
