using MVVM.Exemplo.View.Interfaces;
using MVVM.Exemplo.ViewModels.Base;
using MVVM.Exemplo.ViewModels.Interfaces;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM.Exemplo.ViewModels
{
    public class LoginViewModel : BaseViewModel, ILoginViewModel
    {
        private string _titulo;
        public string Titulo
        {
            get { return _titulo; }
            set
            {
                _titulo = value;
                NotifyPropertyChanged();
            }
        }

        public string Usuario { get; set; }
        public string Senha { get; set; }

        private ICommand _entrarCommand;
        public ICommand EntrarCommand
        {
            get
            {
                return _entrarCommand ?? (_entrarCommand = new Command(() =>
               {
                   Navigation.PushAsync<IMainViewModel, IMainPage>();
               }));
            }
        }
        public LoginViewModel()
        {
            Titulo = "Login";
        }
    }
}
