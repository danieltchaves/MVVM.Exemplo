using MVVM.Exemplo.View.Interfaces;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM.Exemplo.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginTabletPage : ContentPage, ILoginPage
    {
        public LoginTabletPage()
        {
            InitializeComponent();
        }
    }
}