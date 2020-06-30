using System.Threading.Tasks;
using Xamarin.Forms;

namespace MVVM.Exemplo.ViewModels
{
    public class Navigation : Exemplo.Interfaces.INavigation
    {
        public void PushMain<ViewModel, View>()
        {
            Application.Current.MainPage = new NavigationPage(GetPage<ViewModel, View>());
        }

        public Task PushAsync<ViewModel, View>()
        {
            return Application.Current.MainPage.Navigation.PushAsync(GetPage<ViewModel, View>());
        }

        public async Task PopAsync()
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }

        public async Task PopToRootAsync()
        {
            await Application.Current.MainPage.Navigation.PopToRootAsync();
        }

        public Page GetPage<ViewModel, View>()
        {
            var view = App.AutofacIoC.Resolve<View>() as Page;
            var viewModel = App.AutofacIoC.Resolve<ViewModel>();
            view.BindingContext = viewModel;
            return view;
        }
    }
}
